using NUnit.Framework;
using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;
using static Unity.Collections.Unicode;

public class carcontroller : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    [System.Serializable]
    public class Axleinfo
    {
        public WheelCollider leftWheel;
        public WheelCollider rightWheel;

        public bool motor;
        public bool steering;


    }

    public List<Axleinfo> AxleInfos = new List<Axleinfo>();
    public float maxMortorTorque;
    public float maxSteeringAngle;

    public float normalLinearDamping = 0.5f;
    public float driftLinearDamping = 0.001f;

    // wheel rotating and wheel turning showing
    public void ApplyLocalPositionToVisual(WheelCollider collider)
    {
        if (collider.transform.childCount == 0)
        {
            return;
        }

        Transform visualWheel = collider.transform.GetChild(0);
        Vector3 position;
        Quaternion rotation;

        collider.GetWorldPose(out position, out rotation);

        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }


    private void FixedUpdate()
    {
        float motor = maxMortorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");


        foreach (Axleinfo axleinfo in AxleInfos)
        {   

            // Shift key press
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.linearDamping = driftLinearDamping;
            }
            else
            {
                rb.linearDamping = normalLinearDamping;
            }

            if (axleinfo.steering == true)
            {
                axleinfo.leftWheel.steerAngle = steering;
                axleinfo.rightWheel.steerAngle = steering;

            }
            if (axleinfo.motor == true)
            {
                axleinfo.leftWheel.motorTorque = motor;
                axleinfo.rightWheel.motorTorque = motor;

            }

            ApplyLocalPositionToVisual(axleinfo.leftWheel);
            ApplyLocalPositionToVisual(axleinfo.rightWheel);

        }

    }

    private void Update()
    {
        if (GameManager.instance == null) return;
        if (transform.up.y < 0.2f)
        {
            GameManager.instance.TruckCrashed();
        }
    }

}

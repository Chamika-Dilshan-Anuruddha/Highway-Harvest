using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class carcontroller : MonoBehaviour
{
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
}

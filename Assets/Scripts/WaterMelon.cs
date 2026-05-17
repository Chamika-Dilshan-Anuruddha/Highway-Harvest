using UnityEngine;

public class WaterMelon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        VehicleInventroy vehicleInventory = other.GetComponent<VehicleInventroy>();
        if (vehicleInventory != null)
        {
            vehicleInventory.AddWatermelon();
            gameObject.SetActive(false);
        }
    }
}

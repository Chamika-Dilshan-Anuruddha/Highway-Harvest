using UnityEngine;

public class Strawberry : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        VehicleInventroy vehicleInventory = other.GetComponent<VehicleInventroy>();
        if (vehicleInventory != null)
        {
            vehicleInventory.AddStrawBerry();
            gameObject.SetActive(false);
        }
    }
}

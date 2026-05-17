using UnityEngine;

public class Banana : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        VehicleInventroy vehicleInventory = other.GetComponent<VehicleInventroy>();
        if (vehicleInventory != null)
        {
            vehicleInventory.AddBanana();
            gameObject.SetActive(false);
        }
    }
}


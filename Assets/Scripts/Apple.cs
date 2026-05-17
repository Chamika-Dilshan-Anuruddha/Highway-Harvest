using UnityEngine;

public class Apple : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        VehicleInventroy vehicleInventory = other.GetComponent<VehicleInventroy>();
        if (vehicleInventory != null)
        {
            vehicleInventory.AddApple();
            gameObject.SetActive(false);
        }
    }
}

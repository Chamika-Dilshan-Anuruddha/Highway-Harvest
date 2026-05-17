using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI appleText;
    [SerializeField] private TextMeshProUGUI waterMelonText;
    [SerializeField] private TextMeshProUGUI bananaText;
    [SerializeField] private TextMeshProUGUI strawberryText;
    [SerializeField] private VehicleInventroy vehicle;

    public void Update()
    {
        appleText.text = vehicle.NumberOfApples.ToString();
        waterMelonText.text = vehicle.NumberOfWaterMelons.ToString();
        bananaText.text = vehicle.NumberOfBanana.ToString();
        strawberryText.text = vehicle.NumberOfStrawberry.ToString();

    }


}

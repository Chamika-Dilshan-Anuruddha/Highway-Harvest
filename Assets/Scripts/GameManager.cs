using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public VehicleInventroy vehicle;

    public GameObject winPanel;
    public GameObject failPanel;
    public GameObject needMorePanel;

    public TextMeshProUGUI needMoreText;

    public int requiredFruits = 200;
    public int requiredstrawberrys = 40;

    public void Start()
    {
        Time.timeScale = 1f;
        winPanel.SetActive(false);
        failPanel.SetActive(false);
        needMorePanel.SetActive(false);

    }
    private void Awake()
    {
        instance = this;
    }

    public void TruckCrashed()
    {
        failPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void FinishLevel()
    {   
        if (vehicle == null)
        {
            vehicle = FindAnyObjectByType<VehicleInventroy>();
        }
        int total = vehicle.NumberOfApples + vehicle.NumberOfStrawberry + vehicle.NumberOfBanana + vehicle.NumberOfWaterMelons;
        

        if ((total >= requiredFruits) && (vehicle.NumberOfStrawberry >= requiredstrawberrys) )
        {
            winPanel.SetActive(true);
        }
        else
        {
            needMorePanel.SetActive(true);

            string message = "LEVEL REQUIREMENTS\n\n";
            if (total < requiredFruits)
            {
                message += "Need " + (requiredFruits - total) + " more fruits\n\n";

            }
            if(vehicle.NumberOfStrawberry < requiredstrawberrys)
            {
                message += "Need " + (requiredstrawberrys - vehicle.NumberOfStrawberry) + " more strawberries\n";
            }

            needMoreText.text = message;
        }
 

        Time.timeScale = 0f;
    }

    public void ContinueGame()
    {
        needMorePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

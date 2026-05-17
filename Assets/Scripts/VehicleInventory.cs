using UnityEngine;
using UnityEngine.Events;


public class VehicleInventroy : MonoBehaviour
{
    public int NumberOfApples;
    public int NumberOfWaterMelons;
    public int NumberOfBanana;
    public int NumberOfStrawberry;


    public void AddApple()
    {
        NumberOfApples++;
        
    }

    public void AddWatermelon()
    {
        NumberOfWaterMelons++;
      
    }

    public void AddBanana()
    {
        NumberOfBanana++;

    }

    public void AddStrawBerry()
    {
        NumberOfStrawberry++;

    }


}

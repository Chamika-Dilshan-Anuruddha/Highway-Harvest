using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.FinishLevel();
        }
    }
}

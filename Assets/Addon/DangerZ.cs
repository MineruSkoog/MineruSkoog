using UnityEngine;

public class DangerZ : MonoBehaviour
{
    private HungerManager hM;

    [SerializeField] private float timerReduction = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hM = GameObject.Find("HungerManager").GetComponent<HungerManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        hM.SubtractHungerTime(timerReduction);
    }

    private void OnTriggerStay(Collider other)
    {
        hM.ResetHungerTime();
    }
}

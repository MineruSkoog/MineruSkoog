using UnityEngine;

public class CancelHunger : MonoBehaviour
{
    [SerializeField] private string requiredTag = "Player";
    private HungerManager hM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hM = GameObject.Find("HungerManager").GetComponent<HungerManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == requiredTag)
        {
            hM.canFeelHunger = false;
            Destroy(gameObject);
        }
        
    }
}

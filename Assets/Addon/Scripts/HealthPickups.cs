using UnityEngine;
using Gamekit3D;
public class HealthPickups : MonoBehaviour
{
   [SerializeField] private string requiredTag = "Player";
   [SerializeField] private bool destroyOnTrigger = true;
   
   [SerializeField] private bool fullRegain = false;
   [SerializeField] private int healthAmount =  1;
   private HungerManager hungerManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hungerManager = GameObject.Find("HungerManager").GetComponent<HungerManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(requiredTag))
        {
            if (fullRegain)
            {
                other.GetComponent<Damageable>().ResetDamage();
            }
            else
            {
                other.GetComponent<Damageable>().GainSetHealth(healthAmount);
            }
            hungerManager.ResetTimer();
            if (destroyOnTrigger == true) 
            {
                Destroy(gameObject);
            }
        }
    }
}

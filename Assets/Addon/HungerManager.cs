using UnityEngine;
using Gamekit3D;

public class HungerManager : MonoBehaviour
{
    private Damageable damageTarget;

    [SerializeField] private float damageTime = 15.0f;
    private float maxDamageTime;
    private float timer = 0.0f;
    [SerializeField] private int damageAmount = 1;

    //bool
    public bool canFeelHunger = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageTarget = GameObject.Find("Player").GetComponent<Damageable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canFeelHunger)
        {
            timer += Time.deltaTime;

            if (timer >= damageTime)
            {
                // take Damage
                Damageable.DamageMessage msg = new Damageable.DamageMessage
                {
                    damager = this,
                    amount = damageAmount,
                    damageSource = new Vector3(0, 0, 0).normalized,
                    direction = new Vector3(0, 0, 0).normalized,
                    throwing = false,
                    stopCamera = false
                    
                };
                damageTarget.ApplyDamage(msg);
                resetTimer();
            }
        }
        else 
        {
            Debug.Log("HungerManager is disabled");
        }
    }

    public void resetTimer()
        {
            Debug.Log("Resetting Timer");
            timer = 0.0f;
        }
    public void SubtractHungerTime(float reduction)
        {
            damageTime -= reduction;
            Debug.Log("HungerManager SubtractHungerTime");
        }

    public void ResetHungerTime()
    {
        damageTime =maxDamageTime;
        Debug.Log("HungerManager ResetHungerTime");
    }
}


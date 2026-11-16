using UnityEngine;
using Gamekit3D;

public class HungerManager : MonoBehaviour
{
    private Damageable _damageTarget;

    [SerializeField] private float damageTime = 15.0f;
    private float _maxDamageTime;
    private float _timer = 0.0f;
    [SerializeField] private int damageAmount = 1;

    //bool
    public bool canFeelHunger = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _damageTarget = GameObject.Find("Player").GetComponent<Damageable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canFeelHunger)
        {
            _timer += Time.deltaTime;

            if (_timer >= damageTime)
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
                _damageTarget.ApplyDamage(msg);
                ResetTimer();
            }
        }
        else 
        {
            Debug.Log("HungerManager is disabled");
        }
    }

    public void ResetTimer()
        {
            Debug.Log("Resetting Timer");
            _timer = 0.0f;
        }
    public void SubtractHungerTime(float reduction)
        {
            damageTime -= reduction;
            Debug.Log("HungerManager SubtractHungerTime");
        }

    public void ResetHungerTime()
    {
        damageTime =_maxDamageTime;
        Debug.Log("HungerManager ResetHungerTime");
    }
}


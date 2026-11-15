using UnityEngine;
using Gamekit3D;

public class HungerManager : MonoBehaviour
{
    private Damageable damageTarget;

    [SerializeField] private float damageTime = 15.0f;

    private float timer = 0.0f;

    [SerializeField] private int damageAmount = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageTarget = GameObject.Find("Ellen").GetComponent<Damageable>();
    }

    // Update is called once per frame
    void Update()
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

    private void resetTimer()
        {
            timer = 0.0f;
        }

}


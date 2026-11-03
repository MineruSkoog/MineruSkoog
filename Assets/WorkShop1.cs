using UnityEngine;
using UnityEngine.Events;
using Gamekit3D;
public class WorkShop1 : MonoBehaviour
{
    bool HasWalked = false;
    string name = "John Doe";

    private float speed = 12.12f;

    public int age = 25;

    public UnityEvent onStart;
        
    private SpriteRenderer _spriteRenderer;
    
    Transform _transform;
    
    float timer = 0;
    public GameObject Squares;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        onStart.Invoke();
        age = Random.Range(20, 46);
        
        _transform = GetComponent<Transform>();
        var vector3 = _transform.position;
        vector3.y = 2.26f;
        _transform.position = vector3;

        for (int counter = 0; counter < 10; counter++)
        
        {
            Debug.Log(counter);
            if (counter == 7)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer =+ Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {     
          CheckName();
        } 
        NewMethod();  
    }
    
    void NewMethod()
    { 
       if (Input.GetKeyDown(KeyCode.R))
       {  
        age ++;
       } 
       
    }

    void CheckName()

    {
        Debug.Log(age);
    }
  
}


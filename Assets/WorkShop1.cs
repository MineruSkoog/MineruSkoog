using UnityEngine;

public class WorkShop1 : MonoBehaviour
{
    bool HasWalked = false;
    string name = "John Doe";

    private float speed = 12.12f;

    public int age = 25;

    private SpriteRenderer _spriteRenderer;
    Transform _transform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        _transform = GetComponent<Transform>();
        var vector3 = _transform.position;
        vector3.y = 2.26f;
        _transform.position = vector3;

    }

    // Update is called once per frame
    void Update()
    {
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
        age +=1;
       } 
       
    }

    void CheckName()

    {
        Debug.Log(age);
    }
}

using UnityEngine;
using Gamekit3D;
using FMODUnity;
using FMOD.Studio;

public class WorkS2 : MonoBehaviour
{

    //public float timer = 5f;
    public EventInstance _eventInstance;
    public EventReference _eventReference;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _eventInstance = RuntimeManager.CreateInstance(_eventReference);
        _eventInstance.start();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //timer -= Time.deltaTime;
        //if (timer <= 0)
        {  
            // Note. Can change parameter by typing - _eventInstance.setParameterByName("parameter name", (1) for example);
            // if (timer <= 0 && >= Time.deltaTime;
       // _eventInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }
}

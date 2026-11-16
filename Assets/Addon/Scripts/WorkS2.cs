using UnityEngine;
using Gamekit3D;
using FMODUnity;
using FMOD.Studio;

public class WorkS2 : MonoBehaviour
{
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
        
    }
}

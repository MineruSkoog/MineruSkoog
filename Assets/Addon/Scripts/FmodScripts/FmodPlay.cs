using UnityEngine;

public class FmodPlay : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Simple fmod player
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/FmodPlay", transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

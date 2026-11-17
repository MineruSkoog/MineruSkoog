using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using UnityEngine.Serialization;

//Variable type and it's limits for example "int". Variables like "Speed" or enum 
//array, uses[] allows to input several elements within the "variable" 0 and upwards is the order 

public enum ElementalPower
{   
    none,
    Fire,
    Ice,
    Lightbulb,
    Poison
}






// struct allows several variables within on, put in class needs to declare that you can see it in inspector
[System.Serializable]
public struct CharacterInformation
{   
    public string name;
    public ElementalPower _elementalPower;
    public float speed;
    public bool canfly;
    public int health;
    public int damagePower;
    
}

public class WorkShop2Test : MonoBehaviour
{
    //What does "enum" let you do?, in this case "Elemental power as ex,
    public int[] highScores;
    [FormerlySerializedAs("eventRefer")] public EventReference eventRef;
    public EventInstance eventInstance;
     
     
  public ElementalPower _elements;
  public CharacterInformation _characterInformation;
  //  public CharacterInformation[] _characterInformation; 
  // foreach (CharacterInformation score in character Information)
  private void Start()
  {
      eventInstance = RuntimeManager.CreateInstance(eventRef);
      
      eventInstance.getPlaybackState(out PLAYBACK_STATE state);
      Debug.Log(state);
      
      
      
      
     /* 
      {   
          foreach (CharacterInformation score in _characterInformation)
          {
              switch (score.name)
              {
                  case "Link":
                      Debug.Log("Link");
                      break;
                  case "Samus":
                      Debug.Log("Samus");
                      break;
                  default:
                      Debug.Log("Something is wrong");
                      break;
                  
              }
          }  
          
          
          
          
          
          // checks if the amount of windows has more than the array in the inspector.
         /*for (int i = 0; i < highScores.Length; i++)
          {
              Debug.Log(i);
          }
      }
      /* _elements = ElementalPower.Poison;
       var elementalPower = ElementalPower.Poison;
       if(ElementalPower.Poison = ElementalPower.Poison)
       {
           Debug.Log("Poison selected");
       }
       else
       {
           Debug.Log("Poison not selected");
       }
       {

           Debug.Log("has poison");
       }
    Debug.Log(_elements);
    //Debug.Log("insert array"[element number]
    //Debug.Log(_characterInformation."insert variable";
   }




   void OnTriggerEnter(Collider other)
     {
         if (other.tag == "Player")
         {
         Debug.Log("I'm " + other.name + " and I entered " + other.name);*/
  }
        
    }


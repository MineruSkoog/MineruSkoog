using UnityEngine;
//https://gamedevbeginner.com/enums-in-unity/ for info about enums
//https://gamedevbeginner.com/how-to-use-arrays-in-unity/
//Switchcases for use of bigger "if" cases, Can put if within case- they get sepperated by "break",
// "Break runs the code above it and seperates it from the other cases underneath.


    // notes what regarding things to do check element in array 
// Namespaces at the top is important.

// int i = Random.Range(0,10) Needs to specify Randomtype using unity random ex.
// Debug can also cause issues,  FMOD.STUDIO.Debug; 
public enum Direction
{
       North,
       East,
       South,
       West
}
public class EnumTest : MonoBehaviour
{
    public Direction _direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      switch (_direction)
      {
          case Direction.North:
              Debug.Log("North");
              //if (true == false)
          break;
          case Direction.East:
              Debug.Log("East");
              break;
          case Direction.South:
              Debug.Log("South");
              break;
          case Direction.West:
              Debug.Log("West");
              break;
    }

       /* if (_direction == Direction.North)
        {
        Debug.Log("North Selected");
        }
        else if (_direction != Direction.North)
            {
            Debug.Log("North not Selected");
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
}

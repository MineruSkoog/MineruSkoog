using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;

    public void SpawnSetObject()
    {
        Instantiate(spawnObject, transform.position, Quaternion.identity);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject bgFloors;
    public GameObject groundTile;
    Vector3  SpawnPoint;
    // Start is called before the first frame update
    public void Spawn()
    {
        GameObject temp = Instantiate(groundTile, SpawnPoint, Quaternion.identity);
        SpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    // Update is called once per frame
   private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Spawn();
        }
    }
}

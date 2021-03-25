using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgFloors : MonoBehaviour
{
    FloorSpawner floorSpawner;

    // Start is called before the first frame update
    private void Start()
    {
        floorSpawner = GameObject.FindObjectOfType<FloorSpawner>();
    }

private void OnTriggerExit (Collider other) {
    {
        floorSpawner.Spawn();
        Destroy(gameObject, 4);
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}

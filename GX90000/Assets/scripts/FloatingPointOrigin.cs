using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Camera))]
public class FloatingPointOrigin : MonoBehaviour
{
    public float threshold = 100.0f;
    public LevelLayoutGeneration layoutGenerator;


    void LateUpdate()
    {
        Vector3 cameraPostiion = gameObject.transform.position;
        cameraPostiion.y = 0f;

        if (cameraPostiion.magnitude > threshold)
        {

            for (int z = 0; z < SceneManager.sceneCount; z++)
            {
                foreach (GameObject g in SceneManager.GetSceneAt(z).GetRootGameObjects())
                {
                    g.transform.position -= cameraPostiion;
                }
            }
            Vector3 originDelta  = Vector3.zero - cameraPostiion;
            layoutGenerator.UpdateSpawnOrigin(originDelta);
            Debug.Log("recentering, origin delta = " + originDelta);

        }
    }
}

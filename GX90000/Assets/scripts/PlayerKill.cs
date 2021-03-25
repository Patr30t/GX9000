using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour
{
    public int Respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnCollisionEnter(Collision other) {
       {
           if(other.gameObject.tag == "Obstacle")
           {
               SceneManager.LoadScene(Respawn);
           }
       }
   }
}


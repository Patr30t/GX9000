using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathParticle : MonoBehaviour
{
   

    public ParticleSystem deathParticles;
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            PlayParticles();
        }
    }

   public void PlayParticles()
   {
       Instantiate(deathParticles, transform.position, Quaternion.identity);
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public Rigidbody rb;

    

  

   private void FixedUpdate ()
   {
      Vector3 forwardMove = transform.forward * movementSpeed * Time.fixedDeltaTime;
      rb.MovePosition(rb.position + forwardMove);
   }

   private void Update() {
       {
           float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
           float vMovement = Input.GetAxis("Vertical") * movementSpeed ;

           transform.Translate(new Vector3 (hMovement, 0, vMovement) * Time.deltaTime);
           
       }

       if (rb.position.y < -1f)
       {
           FindObjectOfType<GameManager>().EndGame();
       }
   }
}

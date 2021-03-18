using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControl : MonoBehaviour
{
    //Variables

    private Animator animator;
    public float moveSpeed = 200f;
    public GameObject player;

    private Rigidbody characterBody;
    private float ScreenWidth;

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        characterBody = player.GetComponent<Rigidbody> ();

        animator = GetComponent<Animator>();

    }



    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while(i< Input.touchCount){
            if (Input.GetTouch (i).position.x > ScreenWidth / 2){
                //MOVEMENT RIGHT
                animator.SetBool("IsAttacking", true);
                RunCharacter(5.0f);
            }
            if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
                //Movement LEFT
                animator.SetBool("IsAttacking", true);
                RunCharacter (-5.0f);
            }
            ++i;
        }
    }
        private void RunCharacter(float horizontalInput){
            //MOVE PLAYER
            characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
        }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovevemnt : MonoBehaviour
{
    public float moveSpeed = 300;
    public GameObject character;

    private Rigidbody rb;
    private float ScreenWidth;

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        rb = character.GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        int i = 0;
		//loop over every touch 
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2) {
				//move right
				MoveCharacter (1.0f);
			}
			if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
				//move left
				MoveCharacter (-1.0f);
			}
			++i;
		}
	}
    private void FixedUpdate() 
    {
       MoveCharacter(Input.GetAxis("Horizontal"));
    }

    private void  MoveCharacter(float horizontalInput)
    {
       rb.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime,0));
    }
}
    


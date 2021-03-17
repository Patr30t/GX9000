using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    private float maxSpeed = 1f;
    private  Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Input.gyro.enabled = true;
    }

    private void Update() {
        {
            Quaternion deviceRotation = DeviceRotation.Get();

            transform.rotation = deviceRotation;
            
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
            Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMove);
        }
    }
}
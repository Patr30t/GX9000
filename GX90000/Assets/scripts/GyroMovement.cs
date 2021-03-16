using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMovement : MonoBehaviour
{

    public UnityEngine.Gyroscope gyro;
   


    // Start is called before the first frame update
    private void Start()
    {
    
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            Input.gyro.enabled = true;
            
        }
    }

    void Update() {
        
    
        if(SystemInfo.supportsGyroscope)
        {
            if (SystemInfo.supportsGyroscope)
            transform.rotation = GyroToUnity(Input.gyro.attitude);
        }

         Quaternion GyroToUnity (Quaternion q) {
            {
                return new Quaternion(q.x, q.y, -q.z, -q.w);
            }
        }

      
}
}

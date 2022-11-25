using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    float yRotate;
    public float menuCameraRotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, yRotate * Time.deltaTime * menuCameraRotateSpeed, 0);
       yRotate += Time.deltaTime;
       if (yRotate >= 180){yRotate-=360;}
    }
}

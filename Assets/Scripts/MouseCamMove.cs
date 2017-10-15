using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// class for main camera movement
/// Last Changed by Philip on 15.10.2017
/// </summary>
public class MouseCamMove : MonoBehaviour
{
    public float speed;
    

    // 
    void Update()
    {
        MoveCam();
    }
     

    /// <summary>
    /// If mouse key 2 is pressed
    /// and mouse is moved,
    /// cam moves in same direction
    /// </summary>
    private void MoveCam()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (Input.GetAxis("Mouse X") != 0.0f)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f,
                    Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }
        }
    }

}

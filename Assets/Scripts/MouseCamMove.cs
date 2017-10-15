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
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") != 0.0f)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f,
                Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }

    }

}

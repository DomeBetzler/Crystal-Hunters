using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// class for main camera movement
/// </summary>
public class MouseCamMove : MonoBehaviour
{
    //private var for parant object of camera and boxes
    [SerializeField] private GameObject camParent;

    /// <summary>
    /// calls MouseMove
    /// </summary>
    void Update ()
	{
	    MouseMove();
    }


    /// <summary>
    /// It moves the parentobject with
    /// cam and boxes in a direction
    /// </summary>
    /// <param name="other">gameobject it collides with</param>
    //TODO 
    //TODO Won't go in Trigger
    //TODO
    void OnTriggerEnter(Collider other)
    {
        //TODO 
        //TODO parentobject wont move
        //TODO
        if (other.gameObject.CompareTag("Up"))
        {
            other.gameObject.transform.position += new Vector3(0,0,1);
            Console.WriteLine("Up");
        }
        if (other.gameObject.CompareTag("Down"))
        {
            other.gameObject.transform.position += new Vector3(0, 0, -1);
            Console.WriteLine("Down");

        }
        if (other.gameObject.CompareTag("Left"))
        {
            other.gameObject.transform.position += new Vector3(-1, 0, 0);
            Console.WriteLine("Left");

        }
        if (other.gameObject.CompareTag("Right"))
        {
            other.gameObject.transform.position += new Vector3(1, 0, 0);
            Console.WriteLine("Right");

        }
    }

    /// <summary>
    /// casts a ray and sets the position of
    /// the gameobject this is attached to
    /// to the position of the mouse
    /// </summary>
    private void MouseMove()
    {
        //TODO 
        //TODO ball laggs behind
        //TODO sync only every frame
        //TODO FixedUpdate would be even later
        //TODO
        RaycastHit hitInfo;
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(mouseRay, out hitInfo))
        {
            Vector3 positionMouse = hitInfo.point;
            positionMouse.y = 0.5f;
            this.transform.position = positionMouse;
        }
    }

}

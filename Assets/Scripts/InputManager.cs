using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] PlayerScript PlayerScript;

    [Header("Settings")]
    
    internal bool joystick = true;

    [Space]
    
    [Header("Parameters")]
    
    internal float xySpeed = 20;

    internal float lookSpeed = 340;

    internal float forwardSpeed = 6;
    
    void Start()
    {
        Debug.Log("Input script started...");
    }

    // Update is called once per frame
    void Update()
    {
        float h = joystick ? Input.GetAxis("Horizontal") : Input.GetAxis("Mouse X");
        float v = joystick ? Input.GetAxis("Vertical") : Input.GetAxis("Mouse Y");
        
        if (Input.GetKeyDown(KeyCode.A) ||(Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            PlayerScript.isLeftPressed = true;
        }
        else
        {
            PlayerScript.isLeftPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.D) ||(Input.GetKeyDown(KeyCode.RightArrow)))
        {
            PlayerScript.isRightPressed = true;
        }
        else
        {
            PlayerScript.isRightPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            PlayerScript.isDownPressed = true;
        }
        else
        {
            PlayerScript.isDownPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.W)||(Input.GetKeyDown(KeyCode.UpArrow)))
        {
            PlayerScript.isUpPressed = true;
        }
        else
        {
            PlayerScript.isUpPressed = false;
        }
    }
}

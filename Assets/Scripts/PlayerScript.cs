using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    internal InputManager inputScript;

    [SerializeField]
    internal PlayerMovement movementScript;

    [SerializeField]
    internal PlayerCollision collisionScript;

    [SerializeField]
    internal int health;

    [SerializeField] 
    internal float enginePower;
    
    internal bool isLeftPressed;
    internal bool isRightPressed;
    internal bool isUpPressed;
    internal bool isDownPressed;
    
    void Start()
    {
        Debug.Log("Player script started...");
    }
}

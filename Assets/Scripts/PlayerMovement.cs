using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerScript PlayerScript;

    internal Rigidbody rb;

    internal SpriteRenderer _spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Movement script started...");
        rb = GetComponent<Rigidbody>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        
        if (PlayerScript.isLeftPressed)
        {
            movePlayerLeft();
        }
        if (PlayerScript.isRightPressed)
        {
            movePlayerRight();
        }

        if (PlayerScript.isUpPressed)
        {
            movePlayerUp();
        }

        if (PlayerScript.isDownPressed)
        {
            movePlayerDown();
        }
    }

    private void movePlayerLeft()
    {
        rb.velocity = new Vector3(-PlayerScript.enginePower,0,0);
    }
    private void movePlayerRight()
    {
         rb.velocity = new Vector3(PlayerScript.enginePower,0, 0);
    }
    private void movePlayerUp()
    {
        rb.velocity = new Vector3(0,PlayerScript.enginePower,0);
    }
    private void movePlayerDown()
    {
        rb.velocity = new Vector3(0, -PlayerScript.enginePower, 0);
     
    }

}


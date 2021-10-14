using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController2 : MonoBehaviour
{
    public bool MoveX = true;
    public bool MoveY = false;


    public float Movespeed = 5f;
    public float MaxDistX = 10f;
    public float MinDistX = 0f;
    public float MaxDistY = 10f;
    public float MinDistY = 0f;

    private float StartposX;
    private float StartposY;

    private int moveX = 0;
    private int moveY = 0;

    public bool AutoClose = false;
    public bool AutoOpen = false;
    public bool Open = false; //True = Open, False = Close


    private Rigidbody2D rigidbody2d;
    

    Vector2 movement;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }


    void Start()
    {
        // Saves the starting position of the object
        StartposX = transform.localPosition.x;
        StartposY = transform.localPosition.y;
    }


    void Update()
    {
 
        Movement();

    }

    public void Movement()
    {
        // Checks if the object should move on the x axis
        if (MoveX == true)
        {
            // Makes the object stop at the opened and closed position
            if (transform.localPosition.x >= StartposX + MaxDistX && Open == true || transform.localPosition.x <= StartposX - MinDistX && Open == false)
            {
                moveX = 0;
                if (transform.localPosition.x >= StartposX + MaxDistX && AutoClose == true)
                {
                    Open = false;
                }
                else if (transform.localPosition.x <= StartposX - MinDistX && AutoOpen == true)
                {
                    Open = true;
                }
            }
            else
            {
                moveX = 1;
            }
        }
        // Checks if the object should move on the y axis
        if (MoveY == true)
        {
            // Makes the object stop at the opened and closed position
            if (transform.localPosition.y >= StartposY + MaxDistY && Open == true || transform.localPosition.y <= StartposY - MinDistY && Open == false)
            {
                moveY = 0;
                if (transform.localPosition.y >= StartposY + MaxDistY && AutoClose == true)
                {
                    Open = false;
                }
                else if (transform.localPosition.y <= StartposY - MinDistY && AutoOpen == true)
                {
                    Open = true;
                }
            }
            else
            {
                moveY = 1;
            }
        }


        // Makes the object move in different directions
        if (Open == true)
        {
            movement = new Vector2(moveX, moveY) * Movespeed;
        }
        else if (Open == false)
        {
            movement = new Vector2(moveX, moveY) * -Movespeed;
        }
        else
        {
            movement = new Vector2(0, 0);
        }
        rigidbody2d.velocity = movement;


    }
}

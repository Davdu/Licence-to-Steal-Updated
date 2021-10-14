using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool MoveX = true;
    public bool MoveY = false;
    private int moveX = 0;
    private int moveY = 0;

    public float Movespeed = 5f;
    public float DistX = 10f; //Negativ = left, positive = right
    public float DistY = 10f;

    private float StartposX;
    private float StartposY;

    public bool Open = false; //True = Open, False = Close
    public bool Active = false;

    private Rigidbody2D rigidbody2d;

    
    Vector2 movement;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }

    // Start is called before the first frame update
    void Start()
    {
        // Saves the starting position of the object
        StartposX = transform.localPosition.x;
        StartposY = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Calls for the Void Movement
            Movement();

    }

    public void Movement()
    {
        // Checks if the object should move on the x axis
        if (MoveX == true)
        {
            if (transform.localPosition.x >= StartposX + DistX && Open == true) // Makes the object stop at the open position and readies it for closing
            {
                Active = false;
                Open = false;
            }
            else if (transform.localPosition.x <= StartposX && Open == false) // Makes the object stop at the closed position and readies it for opening
            {
                Active = false;
                Open = true;
            }
        }
        // Checks if the object should move on the y axis
        if (MoveY == true)
        {
            if (transform.localPosition.y >= StartposY + DistY && Open == true) // Makes the object stop at the open position and readies it for closing
            {
                Active = false;
                Open = false;
            }
            else if (transform.localPosition.y <= StartposY && Open == false) // Makes the object stop at the closed position and readies it for opening
            {
                Active = false;
                Open = true;
            }
        }


        // Sets values for the ints depending on the allowed movement on the x and y axis
        if (MoveX == true)
        {
            moveX = 1;
        }
        else
        {
            moveX = 0;
        }

        if (MoveY == true)
        {
            moveY = 1;
        }
        else
        {
            moveY = 0;
        }


        // Makes the object move if the bool 'Active' is true
        if (Open == true && Active == true)
        {
            movement = new Vector2(moveX, moveY) * Movespeed;
        }
        else if (Open == false && Active == true)
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

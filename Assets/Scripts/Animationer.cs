using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationer : MonoBehaviour
{
    public Vector2 Move;
    public Rigidbody2D rigidbody2d;
    public bool PlayerIsMoving;
   // public Animator animator;

    // Start is called before the first frame update
    public void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Move = rigidbody2d.velocity;
        if (Mathf.Abs(Move.x) >= 1f || Mathf.Abs(Move.y) >= 1f)
        {
            PlayerIsMoving = true;
           // animator.SetBool("IsMoving", true);
            print("isMove");      
        }
        else
        {
            PlayerIsMoving = false;
           // animator.SetBool("IsMoving", false);
            print("isNotMove");
        }
    }
}

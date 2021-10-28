using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float Speed;
    public float MinDist;
    public float rotationSpeed;
    private Transform Player1;
    private Transform Player2;
    private float DistP2;
    private float DistP1;
    public bool ChasePlayer1;

    Vector2 currentTarget;


    

    // Start is called before the first frame update
    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Transform>();
        Player2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        // Finds the distance to each player
        DistP1 = Vector2.Distance(transform.position, Player1.position);
        DistP2 = Vector2.Distance(transform.position, Player2.position);

        {

            // Determines which player to chase
            if (DistP1 <= DistP2)
            {
                ChasePlayer1 = true;
                currentTarget = Player1.position;
            }
            else
            {
                ChasePlayer1 = false;
                currentTarget = Player2.position;
            }


        }



        // movement
        if (ChasePlayer1 == true && DistP1 > MinDist )
        {
            transform.position = Vector2.MoveTowards(transform.position, Player1.position, Speed * Time.deltaTime);

        }
        if (ChasePlayer1 == false && DistP2 > MinDist)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player2.position, Speed * Time.deltaTime);

        }

        // rotation
        float angle = Mathf.Atan2(transform.position.x - currentTarget.x, currentTarget.y - transform.position.y) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

}

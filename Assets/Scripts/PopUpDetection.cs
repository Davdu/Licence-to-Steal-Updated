using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopUpDetection : MonoBehaviour

{
    private Transform Player1Pos;
    private Transform Player2Pos;
    private GameObject Player1;
    public GameObject Player2;

    public float InteractDist;
    public bool IndenForRangeP1;
    public bool IndenForRangeP2;
    private bool ReadyP1;
    private bool ReadyP2;
    public GameObject PopUp1;
    public GameObject PopUp2;
    public TextMesh PopUpP1;
    public TextMesh PopUpP2;

    [Header("Tekst")]
    public string PopUpText;
    public bool ForskelligePopups;
    public string PopUpTextP1;
    public string PopUpTextP2;

    //finder playernes position og Textmeshene PopUp1 og PopUp2  
    void Awake()
    {

        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player1Pos = Player1.transform;
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        Player2Pos = Player2.transform;


        PopUp1 = Player1.transform.GetChild(0).gameObject;
        PopUpP1 = PopUp1.GetComponent<TextMesh>();
        PopUp2 = Player2.transform.GetChild(0).gameObject;
        PopUpP2 = PopUp2.GetComponent<TextMesh>();
    }

    //detection script og pop up script for P1 og P2
    void Update()

    {

        PopUp1.transform.position = Player1.transform.position + new Vector3(0, -2, -2);
        PopUp1.transform.rotation = Quaternion.Euler(0, 0, 0);

        PopUp2.transform.position = Player2.transform.position + new Vector3(0, -2, -2);
        PopUp2.transform.rotation = Quaternion.Euler(0, 0, 0);
            



        if (Player1Pos)
        {
            // udregner Player 1 position
            float dist = Vector2.Distance(Player1Pos.position, transform.position);

            //detector om playeren er inden for range.
            if (dist <= InteractDist)
            {
                IndenForRangeP1 = true;
                ReadyP1 = true;
            }
            else IndenForRangeP1 = false;

            //hvis playeren er inden for range tjekker den om den skal bruge ForskelligePopups 
            if (IndenForRangeP1 == true)

            {
                if (ForskelligePopups == true)
                {
                    PopUpP1.text = PopUpTextP1;
                }

                if (ForskelligePopups == false)
                {
                    PopUpP1.text = PopUpText;
                }
            }
            //Fjerner teksten når playeren ikke længere er indend for range
            if (IndenForRangeP1 == false && ReadyP1 == true)
            {
                PopUpP1.text = " ";
                ReadyP1 = false;

            }
        }
        // det samme skript for player 2
        if (Player2Pos)
        {
            float dist = Vector2.Distance(Player2Pos.position, transform.position);

            if (dist <= InteractDist)
            {
                IndenForRangeP2 = true;
                ReadyP2 = true;
            }
            else IndenForRangeP2 = false;


            if (IndenForRangeP2 == true)
            {
                if (ForskelligePopups == true)
                {
                    PopUpP2.text = PopUpTextP2;
                }

                if (ForskelligePopups == false)
                {
                    PopUpP2.text = PopUpText;
                }
            }
            if (IndenForRangeP2 == false && ReadyP2 == true)
            {
                PopUpP2.text = " ";
                ReadyP2 = false;

            }
            }

        }
    }







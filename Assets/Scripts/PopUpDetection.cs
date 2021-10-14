using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopUpDetection : MonoBehaviour

{
    // public Transform Player2;
    public Transform Player1;
    public Transform Player2;
    public float InteractDist;
    public bool IndenForRangeP1;
    public bool IndenForRangeP2;
    public bool ReadyP1;
    public bool ReadyP2;
    public TextMesh PopUpP1;
    public TextMesh PopUpP2;
    public string PopUpText;
    public bool ForskelligePopups;
    public string PopUpTextP1;
    public string PopUpTextP2;

    //detection script og pop up script for P1 og P2
    void Update()
    {
        if (Player1)
        {
            float dist = Vector2.Distance(Player1.position, transform.position);
            

            if (dist <= InteractDist)
            {
                IndenForRangeP1 = true;
                ReadyP1 = true;
            }
            else IndenForRangeP1 = false;


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

            if (IndenForRangeP1 == false && ReadyP1 == true)
            {
                PopUpP1.text = " ";
                ReadyP1 = false;

            }
        }
        if (Player2)
        {
            float dist = Vector2.Distance(Player2.position, transform.position);

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

                if(ForskelligePopups == false)
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




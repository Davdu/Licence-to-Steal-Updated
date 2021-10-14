using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Knap : MonoBehaviour
{
    public GameObject Door;
    public GameObject knap;
    public PopUpDetection PopUpScript;
    public DoorController2 DoorScript;
    public bool PushOnce;
    public bool PermaActivate;
  

    // Start is called before the first frame update
    private void Awake()
    {
        //s�tter kanppen til det gameobject som scriptet er p�
        knap = this.gameObject;
        //anskaffer informationer fra PopupScript og DoorScript
        PopUpScript = knap.GetComponent<PopUpDetection>();

        DoorScript = Door.GetComponent<DoorController2>();

    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()

    {

        // hvis en af playerne er inden for range og trykker p� Intereact �bner d�ren, ellers lukker den
            if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1") || PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2") || PermaActivate == true)
            {
                DoorScript.Open = true;

            // hvis ToggleSwitch er p� forbliver d�ren �ben permanent 
            if(PushOnce == true)
            {
                PermaActivate = true;
            }

            }

            else
                DoorScript.Open = false;

    }
}



    
 

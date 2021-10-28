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
    public Sprite R�dknap;
    public Sprite Gr�nknap;
    public SpriteRenderer ThisSprite;


    // Start is called before the first frame update
    private void Awake()
    {
        //s�tter kanppen til det gameobject som scriptet er p�
        knap = this.gameObject;
        //anskaffer informationer fra PopupScript og DoorScript
        PopUpScript = knap.GetComponent<PopUpDetection>();

        DoorScript = Door.GetComponent<DoorController2>();

        // ThisSprite = this.GetComponent<SpriteRenderer>();
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()

    {

        // hvis en af playerne er inden for range og trykker p� Intereact �bner d�ren
        if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1") || PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2") || PermaActivate == true)
        {
            DoorScript.Open = true;
            ThisSprite.sprite = Gr�nknap;
            // hvis ToggleSwitch er p� forbliver d�ren �ben permanent 
            if (PushOnce == true)
            {
                PermaActivate = true;
            }
        }
        // ellers lukker den
        else
        {
            DoorScript.Open = false;
            ThisSprite.sprite = R�dknap;
        }

    }
}





    
 

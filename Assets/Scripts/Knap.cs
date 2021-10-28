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
    public Sprite Rødknap;
    public Sprite Grønknap;
    public SpriteRenderer ThisSprite;


    // Start is called before the first frame update
    private void Awake()
    {
        //sætter kanppen til det gameobject som scriptet er på
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

        // hvis en af playerne er inden for range og trykker på Intereact åbner døren
        if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1") || PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2") || PermaActivate == true)
        {
            DoorScript.Open = true;
            ThisSprite.sprite = Grønknap;
            // hvis ToggleSwitch er på forbliver døren åben permanent 
            if (PushOnce == true)
            {
                PermaActivate = true;
            }
        }
        // ellers lukker den
        else
        {
            DoorScript.Open = false;
            ThisSprite.sprite = Rødknap;
        }

    }
}





    
 

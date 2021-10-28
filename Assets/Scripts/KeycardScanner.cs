using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeycardScanner : MonoBehaviour
{
    public bool OnOfff;
    public GameObject Door;
    public GameObject KeyScanner;
    public PopUpDetection PopUpScript;
    public DoorController2 DoorScript;
    public PlayerInventory PlayerInventory;
    public GameObject InventoryManager;
    public bool ScanRed;
    public bool ScanYellow;
    public bool ScanGreen;
    public GameObject Redkeycard;
    public GameObject Yellowkeycard;
    public GameObject Greenkeycard;
    public bool Ready;
    public Transform ThisPos;

    private void Awake()
    {


        //  Redkeycard = GameObject.FindGameObjectWithTag("RedkeycardProp");
        //  Yellowkeycard = GameObject.FindGameObjectWithTag("YellowkeycardProp");
        // Greenkeycard = GameObject.FindGameObjectWithTag("GreenkeycardProp");

        //sætter keyscanneren til det gameobject som scriptet er på
        KeyScanner = this.gameObject;


        //anskaffer informationer fra PopupScript og DoorScript
        PopUpScript = KeyScanner.GetComponent<PopUpDetection>();
        DoorScript = Door.GetComponent<DoorController2>();

        InventoryManager = GameObject.FindGameObjectWithTag("InventoryManager");
        PlayerInventory = InventoryManager.GetComponent<PlayerInventory>();
    }

    void Start()
    {
        Ready = true;

        // Vector2 ThisPos = transform.position;
    }



    void Update()

    {
        IEnumerator VentLige()

        {
            Ready = false;
            yield return new WaitForSeconds(0.3f);
            Ready = true;
        }
        {

            if (PopUpScript.IndenForRangeP1 == true)
            {
                if (ScanRed == true)
                {



                    if (Ready == true && Input.GetButton("IntP1") && PlayerInventory.P1HasRedKeycard == true)
                    {
                        PopUpScript.PopUpText = "take RedkeyCard";
                        PlayerInventory.P1HasRedKeycard = false;
                        Instantiate(Redkeycard, transform.position + new Vector3 (0,0,-1), Quaternion.identity);
                        StartCoroutine(VentLige());
                        DoorScript.Open = true;
                        OnOfff = true;


                    }
                    if (Ready == true && OnOfff == true && Input.GetButton("IntP1") && PlayerInventory.P1HasRedKeycard == false)
                    {
                        PopUpScript.PopUpText = "Place RedkeyCard";
                        PlayerInventory.P1HasRedKeycard = true;
                        Destroy(GameObject.FindWithTag("RedKeycardProp"));
                        StartCoroutine(VentLige());
                        DoorScript.Open = false;
                        OnOfff = false;
                    }
                }
                if (ScanYellow == true)
                {
                    if (Ready == true && Input.GetButton("IntP1") && PlayerInventory.P1HasYellowKeycard == true)
                    {
                        PopUpScript.PopUpText = "take YellowkeyCard";
                        PlayerInventory.P1HasYellowKeycard = false;
                        Instantiate(Yellowkeycard, transform.position + new Vector3(0, 0, -1), Quaternion.identity);
                        StartCoroutine(VentLige());
                        DoorScript.Open = true;
                        OnOfff = true;


                    }
                    if (Ready == true && OnOfff == true && Input.GetButton("IntP1") && PlayerInventory.P1HasYellowKeycard == false)
                    {
                        PopUpScript.PopUpText = "Place YellowkeyCard";
                        PlayerInventory.P1HasYellowKeycard = true;
                        Destroy(GameObject.FindWithTag("YellowKeycardProp"));
                        StartCoroutine(VentLige());
                        DoorScript.Open = false;
                        OnOfff = false;
                    }
                }
                if (ScanGreen == true)

                {
                    if (Ready == true && Input.GetButton("IntP1") && PlayerInventory.P1HasGreenKeycard == true)
                    {
                        PopUpScript.PopUpText = "take GreenkeyCard";
                        PlayerInventory.P1HasGreenKeycard = false;
                        Instantiate(Greenkeycard, transform.position + new Vector3(0, 0, -1), Quaternion.identity);
                        StartCoroutine(VentLige());
                        DoorScript.Open = true;
                        OnOfff = true;


                    }
                    if (Ready == true && OnOfff == true && Input.GetButton("IntP1") && PlayerInventory.P1HasGreenKeycard == false)
                    {
                        PopUpScript.PopUpText = "Place GreenkeyCard";
                        PlayerInventory.P1HasGreenKeycard = true;
                        Destroy(GameObject.FindWithTag("GreenKeycardProp"));
                        StartCoroutine(VentLige());
                        DoorScript.Open = false;
                        OnOfff = false;
                    }

                }
            }
        }
    
    


        { 
            if (PopUpScript.IndenForRangeP2 == true)
            {
                    if (ScanRed == true)
                    {

                        if (Ready == true && Input.GetButton("IntP2") && PlayerInventory.P2HasRedKeycard == true)
                        {
                        PopUpScript.PopUpText = "take RedkeyCard";
                        PlayerInventory.P2HasRedKeycard = false;
                            Instantiate(Redkeycard, transform.position + new Vector3(0, 0, -1), Quaternion.identity);
                            StartCoroutine(VentLige());
                            DoorScript.Open = true;
                            OnOfff = true;
                        

                    }
                        if (Ready == true && OnOfff == true && Input.GetButton("IntP2") && PlayerInventory.P2HasRedKeycard == false)
                        {
                            PopUpScript.PopUpText = "Place RedkeyCard";
                            PlayerInventory.P2HasRedKeycard = true;
                            Destroy(GameObject.FindWithTag("RedKeycardProp"));
                            StartCoroutine(VentLige());
                            DoorScript.Open = false;
                            OnOfff = false;
                        }
                    }
                    if (ScanYellow == true)
                    {
                        if (Ready == true && Input.GetButton("IntP2") && PlayerInventory.P2HasYellowKeycard == true)
                        {

                        PopUpScript.PopUpText = "Take YellowkeyCard";
                        PlayerInventory.P2HasYellowKeycard = false;
                            Instantiate(Yellowkeycard, transform.position + new Vector3(0, 0, -1), Quaternion.identity);
                            StartCoroutine(VentLige());
                            DoorScript.Open = true;
                            OnOfff = true;


                        }
                        if (Ready == true && OnOfff == true && Input.GetButton("IntP2") && PlayerInventory.P2HasYellowKeycard == false)
                        {
                        PopUpScript.PopUpText = "Place YellowkeyCard";

                            PlayerInventory.P2HasYellowKeycard = true;
                            Destroy(GameObject.FindWithTag("YellowKeycardProp"));
                            StartCoroutine(VentLige());
                            DoorScript.Open = false;
                            OnOfff = false;

                        }
                    }
                    if (ScanGreen == true)

                    {
                        if (Ready == true && Input.GetButton("IntP2") && PlayerInventory.P2HasGreenKeycard == true)
                        {
                            PopUpScript.PopUpText = "Take GreenkeyCard";
                            PlayerInventory.P2HasGreenKeycard = false;
                            Instantiate(Greenkeycard, transform.position + new Vector3(0, 0, -1), Quaternion.identity);
                            StartCoroutine(VentLige());
                            DoorScript.Open = true;
                            OnOfff = true;


                        }
                        if (Ready == true && OnOfff == true && Input.GetButton("IntP2") && PlayerInventory.P2HasGreenKeycard == false)
                        {
                            PopUpScript.PopUpText = "Place GreenkeyCard";
                            PlayerInventory.P2HasGreenKeycard = true;
                            Destroy(GameObject.FindWithTag("GreenKeycardProp"));
                            StartCoroutine(VentLige());
                            DoorScript.Open = false;
                            OnOfff = false;
                        }
                    }
                }
            }
        }
    }





























       
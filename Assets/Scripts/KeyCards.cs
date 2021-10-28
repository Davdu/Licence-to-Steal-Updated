using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCards : MonoBehaviour
{
    public bool RedKeycard;
    public bool GreenKeycard;
    public bool YellowKeycard;
    public PopUpDetection PopUpScript;
    public GameObject Keycard;
    public PlayerInventory InventoryScript;
    public GameObject InventoryManager;

    private void Awake()
    {

    
    
        Keycard = this.gameObject;
        PopUpScript = Keycard.GetComponent<PopUpDetection>();
        {
            InventoryManager = GameObject.FindGameObjectWithTag("InventoryManager");
            InventoryScript = InventoryManager.GetComponent<PlayerInventory>();
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (RedKeycard == true)
            if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1"))
            {
                InventoryScript.P1HasRedKeycard = true;
                PopUpScript.PopUpP1.text = " ";
                Destroy(Keycard);
            }


        if (GreenKeycard == true)
            if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1"))
            {
                InventoryScript.P1HasGreenKeycard = true;
                PopUpScript.PopUpP1.text = " ";
                Destroy(Keycard);
            }


        if (YellowKeycard == true)
            if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1"))
            {
                InventoryScript.P1HasYellowKeycard = true;
                PopUpScript.PopUpP1.text = " ";
                Destroy(this.gameObject);
            }

        if (RedKeycard == true)
            if (PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2"))
            {
                InventoryScript.P2HasRedKeycard = true;
                PopUpScript.PopUpP2.text = " ";
                Destroy(Keycard);
            }


        if (GreenKeycard == true)
            if (PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2"))
            {
                InventoryScript.P2HasGreenKeycard = true;
                PopUpScript.PopUpP2.text = " ";
                Destroy(Keycard);
            }


        if (YellowKeycard == true)
            if (PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2"))
            {
                InventoryScript.P2HasYellowKeycard = true;
                PopUpScript.PopUpP2.text = " ";
                Destroy(Keycard);
            }
    }
}







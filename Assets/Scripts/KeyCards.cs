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
    public GameObject InventroryController;

    private void Awake()

    {
        PopUpScript = Keycard.GetComponent<PopUpDetection>();
        InventoryScript = InventroryController.GetComponent<PlayerInventory>();
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
                Destroy(Keycard);
            }


        if (GreenKeycard == true)
            if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1"))
            {
                InventoryScript.P1HasGreenKeycard = true;
                Destroy(Keycard);
            }


        if (YellowKeycard == true)
            if (PopUpScript.IndenForRangeP1 == true && Input.GetButton("IntP1"))
            {
                InventoryScript.P1HasYellowKeycard = true;
                Destroy(Keycard);
            }

        if (RedKeycard == true)
            if (PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2"))
            {
                InventoryScript.P2HasRedKeycard = true;
                Destroy(Keycard);
            }


        if (GreenKeycard == true)
            if (PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2"))
            {
                InventoryScript.P2HasGreenKeycard = true;
                Destroy(Keycard);
            }


        if (YellowKeycard == true)
            if (PopUpScript.IndenForRangeP2 == true && Input.GetButton("IntP2"))
            {
                InventoryScript.P2HasYellowKeycard = true;
                Destroy(Keycard);
            }
    }
}







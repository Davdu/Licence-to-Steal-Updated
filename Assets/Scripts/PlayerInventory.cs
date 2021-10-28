using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Header("Player1Pos")]
    public bool P1HasRedKeycard;
    public bool P1HasGreenKeycard;
    public bool P1HasYellowKeycard;
    [Header("Player2")]
    public bool P2HasRedKeycard;
    public bool P2HasGreenKeycard;
    public bool P2HasYellowKeycard;

    public GameObject RedkeyP1;
    public GameObject YellowkeyP1;
    public GameObject GreenkeyP1;
    public GameObject RedkeyP2;
    public GameObject YellowkeyP2;
    public GameObject GreenkeyP2;


    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (P1HasRedKeycard == true)
            {
                RedkeyP1.gameObject.SetActive(true);
            }
            else
                RedkeyP1.gameObject.SetActive(false);

            if (P1HasYellowKeycard == true)
            {
                YellowkeyP1.gameObject.SetActive(true);
            }
            else
                YellowkeyP1.gameObject.SetActive(false);

            if (P1HasGreenKeycard == true)
            {
                GreenkeyP1.gameObject.SetActive(true);
            }
            else
                GreenkeyP1.gameObject.SetActive(false);
        }

        {
            if (P2HasRedKeycard == true)
            {
                RedkeyP2.gameObject.SetActive(true);
            }
            else
                RedkeyP2.gameObject.SetActive(false);

            if (P2HasYellowKeycard == true)
            {
                YellowkeyP2.gameObject.SetActive(true);
            }
            else
                YellowkeyP2.gameObject.SetActive(false);

            if (P2HasGreenKeycard == true)
            {
                GreenkeyP2.gameObject.SetActive(true);
            }
            else
                GreenkeyP2.gameObject.SetActive(false);
        }
    }
}

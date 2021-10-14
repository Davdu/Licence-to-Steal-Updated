using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public bool AlarmActive = false;



    public GameObject Player1;
    public GameObject Player2;

    public DynamicSplitScreen.Testing.PlayerController ControllerScript1;
    public DynamicSplitScreen.Testing.PlayerController ControllerScript2;

    private void Awake()
    {
        ControllerScript1 = Player1.GetComponent<DynamicSplitScreen.Testing.PlayerController>();
        ControllerScript2 = Player2.GetComponent<DynamicSplitScreen.Testing.PlayerController>();


    }


    // Start is called before the first frame update
    void Start()
    {
        Player1 = GameObject.Find("Player1");
        Player2 = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        Alarm();
    }

    void Alarm()
    {
        if (ControllerScript1.Alarm == true || ControllerScript2.Alarm == true)
        {
            AlarmActive = true;
        }
        else
        {
            AlarmActive = false;
        }
    }

}

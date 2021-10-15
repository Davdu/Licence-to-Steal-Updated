using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    [Header("Alarm System")]
    public bool AlarmActive = false;
    public GameObject Player1;
    public GameObject Player2;

    [Header("Money System")]
    public int TotalCashAmount;
    public Text MoneyText;

    public GameObject MoneyPickup1;
    public GameObject MoneyPickup2;
    public GameObject MoneyPickup3;
    public GameObject MoneyPickup4;
    public int MoneyValue1;
    public int MoneyValue2;
    public int MoneyValue3;
    public int MoneyValue4;




    private DynamicSplitScreen.Testing.PlayerController ControllerScript1;
    private DynamicSplitScreen.Testing.PlayerController ControllerScript2;

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

        MoneyText.text = "0$";
    }

    // Update is called once per frame
    void Update()
    {
        Alarm();
        MoneySystem();
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

    void MoneySystem()
    {

        TotalCashAmount = ControllerScript1.PickedMoney + ControllerScript2.PickedMoney;
        MoneyText.text = TotalCashAmount.ToString() + "$";
    }

}

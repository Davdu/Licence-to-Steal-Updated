using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{

    public GameObject Player1;
    public GameObject Player2;

    [Header("Alarm System")]
    public bool AlarmActive = false;
    public AudioSource IntenseMusic;


    [Header("Money System")]
    public int TotalCashAmount;
    public TextMeshProUGUI MoneyText;

    public int MoneyValue1;
    public int MoneyValue2;
    public int MoneyValue3;
    public int MoneyValue4;


    [HideInInspector] public GameObject MoneyPickup1;
    [HideInInspector] public GameObject MoneyPickup2;
    [HideInInspector] public GameObject MoneyPickup3;
    [HideInInspector] public GameObject MoneyPickup4;

    [Header("Random Code")]
    public Text Code1;
    public int randomNum;

    [Header("Enemies")]


    [Header("Win Condition")]
    public bool lvlDone;
    


    // Allows the manager to read from the playercontrollers on both players
    private DynamicSplitScreen.Testing.PlayerController ControllerScript1;
    private DynamicSplitScreen.Testing.PlayerController ControllerScript2;


    private void Awake()
    {
        // Defines the playercontroller scripts from the specific players of wich the manager will read from
        ControllerScript1 = Player1.GetComponent<DynamicSplitScreen.Testing.PlayerController>();
        ControllerScript2 = Player2.GetComponent<DynamicSplitScreen.Testing.PlayerController>();

    }


 
    void Start()
    {
        // Localizes and defines the gameobjects by their name
        Player1 = GameObject.Find("Player1");
        Player2 = GameObject.Find("Player2");

        MoneyPickup1 = GameObject.Find("MoneyPickup1");
        MoneyPickup2 = GameObject.Find("MoneyPickup2");
        MoneyPickup3 = GameObject.Find("MoneyPickup3");
        MoneyPickup4 = GameObject.Find("MoneyPickup4");


        // Makes the MoneyText display 0$, when the game starts
        MoneyText.text = "0$";

        // Makes the void rndNo (random number) run only once, when the game starts
        rndNo();
    }


    void Update()
    {
        Alarm();
        MoneySystem();
        WinCondtition();
        Detected();
    }

    void Alarm()
    {
        // Checks if the Alarm bool on any of the players have been set to True and activates the universal alarm system (basically an "And Gate")
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
        // Collects the total amount of money both players have picked up and displays it to MoneyText
        TotalCashAmount = ControllerScript1.PickedMoney + ControllerScript2.PickedMoney;
        MoneyText.text = TotalCashAmount.ToString() + "$";
    }


    void rndNo()
    {
        // Generates a random number betweeen 0 and 9999 with extra zeroes as padding, if the generated number is with 3 digits (fx. 0432) to assure that the number will always be 4 digits.
        randomNum = Random.Range(0, 10000);
        Code1.text = randomNum.ToString("D4");
    }


    void Detected()
    {
        if (AlarmActive && !IntenseMusic.isPlaying)
        {
            IntenseMusic.Play();
        }
    }


    void WinCondtition()
    {
        if (ControllerScript1.Win == true || ControllerScript2.Win == true)
        {
            lvlDone = true;
        }
    }



}

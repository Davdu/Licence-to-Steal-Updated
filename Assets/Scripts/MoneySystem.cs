using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MoneySystem : MonoBehaviour
{
    public int Cash = 0;
    public Text MoneyText;


    // Start is called before the first frame update
    void Start()
    {
        MoneyText.text = "Points:";
    }


    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "Points: " + Cash.ToString();
    }

}
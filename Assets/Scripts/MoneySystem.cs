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
        MoneyText.text = "0$";
    }


    // Update is called once per frame
    void Update()
    {
        MoneyText.text = Cash.ToString() + "$";
    }

}
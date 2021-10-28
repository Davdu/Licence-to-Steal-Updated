using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{

    public bool StopTime;

    public bool stopwatchActive = false;
    float currentTime;
    public TextMeshProUGUI CurrentTimeText;
    public string TimePassed;

    private GameObject GameManager;
    private GameObject WinZone;
    private Manager Mg;
    private bool WinReady = true;

    public List<string> Scores = new List<string>();

    void Start()
    {
        Time.timeScale = 1;
        currentTime = 0;

        GameManager = GameObject.Find("GameManager");
        WinZone = GameObject.Find("WinZone");
        Mg = GameManager.GetComponent<Manager>();
    }


    private void Update()
    {
        Stoptime();
        Win();

        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        CurrentTimeText.text = time.ToString(@"mm\:ss\:fff");

        TimePassed = time.ToString(@"mm\:ss\:fff");
    }



    void Stoptime()
    {
        if (StopTime == true)
        {
            Time.timeScale = 0;
        }
        else if (StopTime == false)
        {
            Time.timeScale = 1;
        }
    }

    void Win()
    {
        if (Mg.lvlDone == true && WinReady == true)
        {
            stopwatchActive = false;
            Scores.Add(TimePassed);
            WinReady = false;
        }
    }


}

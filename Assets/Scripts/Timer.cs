using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : Finish
{
    Image timerBar;
    public float maTime = 20f;
    float timeLeft;
    public GameObject LossScreen;
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
            LossScreen.SetActive(false);
        }
        else
        {
            LossScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
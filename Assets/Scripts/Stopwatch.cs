using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : Finish
{

    public float timeStart = 0f;
    public Text record;
    public Text stopwatch;

    // Start is called before the first frame update
    void Start()
    {
        stopwatch.text = timeStart.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        if (!FinishGame)
        {
            timeStart += Time.deltaTime;
            stopwatch.text = timeStart.ToString("F2").Replace("." , ":");
        }
        else if (FinishGame)
        {
            GetComponent<Text>().text = "Рекорд уровня - " + timeStart.ToString("F2").Replace(".", ":");
        }
    }
}

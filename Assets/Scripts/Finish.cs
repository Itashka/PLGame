using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : RestartLevel
{
    public static bool FinishGame = false;
    public GameObject FinishScreen;
    private void OnTriggerEnter2D(Collider2D Finish)
    {
        if(Finish.tag == "Player")
        {
            FinishScreen.SetActive(true);
            Time.timeScale = 0f;
            FinishGame = true;
        }
        else
        {
            FinishScreen.SetActive(false);
        }
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}

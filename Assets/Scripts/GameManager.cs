using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : BaseManager
{
    bool isCrafting = true;
    float timeLeft = 80f;
    Text labelTimeLeft;
    GameSceneManager gameSceneManager;

    void Start()
    {
        gameSceneManager = GameObject.FindGameObjectWithTag("GameSceneManager").GetComponent<GameSceneManager>();
    }

    void Update()
    {
        GameObject findTimeLeft = GameObject.FindGameObjectWithTag("TimeLeft");
        if ((findTimeLeft != null) && isCrafting)
        {
            Text labelTimeLeft = findTimeLeft.GetComponent<Text>();
            UpdateTimer(labelTimeLeft);
        }
    }

    public void setIsCrafting(bool state)
    {
        isCrafting = state;
    }

    void UpdateTimer(Text labelTimeLeft)
    {
        timeLeft -= Time.deltaTime;
        labelTimeLeft.text = "Time Left:" + Mathf.Round(timeLeft) + "s";

        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    public void Win(Text Label)
    {
        isCrafting = false;
        Label.text = "You Win";
        // TODO : when the player has
        // 60% of the craft valid. For example.
    }

    public void GameOver()
    {
        Debug.Log("GameOver!");
        isCrafting = false;
        timeLeft = 80f;
        gameSceneManager.LoadMainMenu();
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}

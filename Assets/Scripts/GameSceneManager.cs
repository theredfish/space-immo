using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : BaseManager
{
    GameManager gameManager;
    SoundManager soundManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }
    public void SwitchToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void LoadQuestLevel1()
    {
        soundManager.StopMainTheme();
        soundManager.PlayPlanetCraft();
        SwitchToScene("PlanetCraftLevel1");
        gameManager.setIsCrafting(true);
    }

    public void LoadMainMenu() {
        soundManager.StopPlanetCraft();
        SwitchToScene("MenuScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MenuManager menuManager;

    void Start()
    {
        menuManager.LoadMainMenu();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

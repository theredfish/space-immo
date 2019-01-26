using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit : MonoBehaviour
{
    public void QuitGame() {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

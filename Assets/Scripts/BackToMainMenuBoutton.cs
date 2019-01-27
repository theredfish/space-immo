using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToMainMenuBoutton : MonoBehaviour
{
    // Start is called before the first frame update

    Button selfButton;

    GameManager gameManager;

    void Start()
    {
        selfButton = GetComponent<Button>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        transform.gameObject.SetActive(false);
        selfButton.onClick.AddListener(BackToMainMenu);
    }

    void BackToMainMenu() {
        gameManager.GameOver();
    }

}

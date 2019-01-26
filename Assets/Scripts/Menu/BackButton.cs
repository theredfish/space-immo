using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [SerializeField]
    GameObject CurrentPanel;
    
    [SerializeField]
    GameObject PreviousPanel;

    Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(goToPreviousPanel);
    }

    void goToPreviousPanel() {
        CurrentPanel.SetActive(false);
        PreviousPanel.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour
{
    [SerializeField]
    GameObject OptionPanel;
    
    [SerializeField]
    GameObject MainPanel;

    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(goToOptionPanel);
    }

    // Update is called once per frame
    void goToOptionPanel() {
        MainPanel.SetActive(false);
        OptionPanel.SetActive(true);
    }
}

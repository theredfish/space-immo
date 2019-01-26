using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    Slider slider;
    Text label;

    void Awake()
    {
        slider = GetComponent<Slider>();
        label = transform.Find("PercentText").GetComponent<Text>();
        Debug.Log(label);
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        int currentPercent = Mathf.RoundToInt(slider.value * 100);
        label.text = currentPercent.ToString() + '%';
        Debug.Log(slider.value);
    }

    //TODO faire link avec GameManager et SoundManager
}

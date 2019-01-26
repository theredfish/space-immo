using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{

    Slider volumeSliderLinked;
    Text volumeText;
    // Start is called before the first frame update
    void Start()
    {
        volumeSliderLinked = transform.Find("Slider").GetComponent<Slider>();
        volumeText = transform.Find("PercentText").GetComponent<Text>();
        volumeSliderLinked.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        int currentPercent = Mathf.RoundToInt(volumeSliderLinked.value * 100);
        volumeText.text = currentPercent.ToString() + '%';
        Debug.Log(volumeSliderLinked.value);
    }

    //TODO faire link avec GameManager et SoundManager
}

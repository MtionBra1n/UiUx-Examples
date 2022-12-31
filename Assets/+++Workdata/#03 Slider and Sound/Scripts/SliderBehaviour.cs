using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderBehaviour : MonoBehaviour
{
    private Slider slider;

    public string descriptionTextFront, descriptionTextBack;
    public TextMeshProUGUI valueText;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        ChangeValueText();
    }

    public void ChangeValueText()
    {
        valueText.text = descriptionTextFront + " " + slider.value + " " + descriptionTextBack;
    }

    public void ChangeTextByValue(float value)
    {
        valueText.text = descriptionTextFront + " " + value + " " + descriptionTextBack;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventManager : MonoBehaviour
{
    public Button button_options, button_loading, button_allClose;
    public GameObject container_loading, container_options;

    void Start()
    {
        button_options.onClick.AddListener(Button_Options);
        button_loading.onClick.AddListener(Button_Loading);
        button_allClose.onClick.AddListener(Button_AllClose);
    }

    void Button_Loading()
    {
        container_options.SetActive(false);
        container_loading.SetActive(true);
    }

    void Button_Options()
    {
        container_loading.SetActive(false);
        container_options.SetActive(true);
    }

    void Button_AllClose()
    {
        container_loading.SetActive(false);
        container_options.SetActive(false);
    }
}

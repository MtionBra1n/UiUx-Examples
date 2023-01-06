using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventManager : MonoBehaviour
{
    public Button button_options, button_loading, button_allClose;
    public GameObject container_loading, container_options;

    /// Button Event on a Manager.
    /// Pealse make your functions public, if you want to use the Button Event on Manager.
    /// T.S.
    void Start()
    {
        button_options.onClick.AddListener(Button_Options);
        button_loading.onClick.AddListener(Button_Loading);
        button_allClose.onClick.AddListener(Button_AllClose);
    }


    /// Button on Click via scipt.
    /// Pealse make your functions public, if you want to use the Button Event on Manager.
    /// T.S.

    public void Button_Loading()
    {
        container_options.SetActive(false);
        container_loading.SetActive(true);
    }

    public void Button_Options()
    {
        container_loading.SetActive(false);
        container_options.SetActive(true);
    }

    public void Button_AllClose()
    {
        container_loading.SetActive(false);
        container_options.SetActive(false);
    }
}

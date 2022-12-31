using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject containerLoadMenu, containerOptionsMenu;
    public void Button_LoadMenu()
    {
        containerLoadMenu.SetActive(true);
        containerOptionsMenu.SetActive(false);
    }

    public void Button_OptionsMenu()
    {
        containerLoadMenu.SetActive(false);
        containerOptionsMenu.SetActive(true);
    }

    public void Button_CloseAllMenus()
    {
        containerLoadMenu.SetActive(false);
        containerOptionsMenu.SetActive(false);
    }
}

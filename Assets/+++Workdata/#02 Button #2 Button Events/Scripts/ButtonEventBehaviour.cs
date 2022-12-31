using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventBehaviour : MonoBehaviour
{
    public GameObject[] objContainerTurnOn;
    public GameObject[] objContainerTurnOff;
    
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        for (int i = 0; i < objContainerTurnOn.Length; i++)
        {
            objContainerTurnOn[i].SetActive(true);
        }

        for (int i = 0; i < objContainerTurnOff.Length; i++)
        {
            objContainerTurnOff[i].SetActive(false);
        }
    }
}

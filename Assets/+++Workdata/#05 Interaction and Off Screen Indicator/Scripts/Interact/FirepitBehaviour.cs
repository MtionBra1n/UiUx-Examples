using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using RPGCharacterAnims;
using RPGCharacterAnims.Actions;
using RPGCharacterAnims.Extensions;
using RPGCharacterAnims.Lookups;
using System.Runtime.CompilerServices;

public class FirepitBehaviour : MonoBehaviour
{
    private UiManager uiManager;
    private InteractBehaviour interactBehaviour;

    private void Start()
    {
        uiManager = GameObject.Find("Manager").GetComponent<UiManager>();
    }

    private void Awake()
    {
        interactBehaviour = GetComponent<InteractBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uiManager.SetInteractionButtonText(interactBehaviour.pressButton_text);
            uiManager.SetInteractionDescriptionText(interactBehaviour.interactDescription_text[interactBehaviour.interactId]);

            uiManager.ShowUiContainer(1);        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiManager.ShowUiContainer(0);
            uiManager.PlayAnimation(uiManager.uiElements.anim_interactContainer, uiManager.uiElements.anim_hideName);
        }
    }
}

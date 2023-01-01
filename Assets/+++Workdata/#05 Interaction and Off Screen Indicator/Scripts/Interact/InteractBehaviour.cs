using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InteractBehaviour : MonoBehaviour
{
    public UiManager uiManager;
    public string boolAnimName;

    public string pressButton_text;

    public string[] interactDescription_text;

    public int interactId;

    public void Interact(GameObject other)
    {
        uiManager.SetInteractionDescriptionText(interactDescription_text[interactId]);
    }
}

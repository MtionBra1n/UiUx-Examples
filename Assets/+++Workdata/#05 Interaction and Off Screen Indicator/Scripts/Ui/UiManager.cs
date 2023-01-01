using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public UiElements uiElements;
    public void ShowUiContainer(int index)
    {
        switch (index)
        {
            case 0:

                break;

            case 1: // interact container
                PlayAnimation(uiElements.anim_interactContainer, uiElements.anim_showName);
                break;


            default:
                break;
        }
    }

    public void SetInteractionDescriptionText(string text)
    {
        uiElements.text_InteractDescription.text = text;
        //uiElements.interactContainer.SetActive(false);
        StartCoroutine(InvokeTurnOn(uiElements.anim_interactContainer.gameObject));
    }

    IEnumerator InvokeTurnOn(GameObject obj)
    {
        var csf = obj.GetComponent<ContentSizeFitter>();
        csf.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        yield return null;
        yield return new WaitForEndOfFrame();
        csf.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

        yield return new WaitForEndOfFrame();
        //obj.SetActive(true);
    }

    public void SetInteractionButtonText(string text)
    {
        uiElements.text_InteractButton.text = text;
    }

    public void PlayAnimation(Animator anim, string animName)
    {
        anim.Play(animName);
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public TextMeshProUGUI inventorySlotAmount;

    [HideInInspector]
    public ItemBehaviour itemBehaviour;
    public Image inventorySlotImage;

    public void SelectSlot()
    {
        inventoryManager.SelectItem(itemBehaviour);
    }
}

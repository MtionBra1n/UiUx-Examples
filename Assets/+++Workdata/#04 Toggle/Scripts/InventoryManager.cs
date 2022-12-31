using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<ItemBehaviour> itemBehaviours;
    public List<InventorySlot> inventorySlots;
    public GameObject inventoryDescriptionContainer;

    public Image imageItem;
    public TextMeshProUGUI textPrice, textAmount, textHeader, textDescription;

    private void Awake()
    {
        FillInventory();
    }

    void FillInventory()
    {
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            inventorySlots[i].itemBehaviour = itemBehaviours[i];
            inventorySlots[i].inventorySlotImage.sprite = itemBehaviours[i].item.itemSprite;
            inventorySlots[i].inventorySlotAmount.text = itemBehaviours[i].amount.ToString();
        }

        SelectItem(inventorySlots[0].itemBehaviour);
    }

    public void SelectItem(ItemBehaviour itemBehaviour)
    {
        inventoryDescriptionContainer.SetActive(true);

        textPrice.text = itemBehaviour.item.itemValue.ToString();
        textAmount.text = itemBehaviour.amount.ToString();
        textHeader.text = itemBehaviour.item.itemName;
        textDescription.text = itemBehaviour.item.itemDescription;

        imageItem.sprite = itemBehaviour.item.itemSprite;

        //for special adjustment if a certain item gets selected
        switch (itemBehaviour.item.itemId)
        {
            case 0: // Bow

                break;

            case 1: // Staff

                break;

            case 2: // Meat
                
                break;

            case 3: // Hide

                break;

            case 4: // Copper

                break;

            case 5: // Helmet

                break;

            default:
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<Toggle> inventorySlots;

    public GameObject inventoryDescriptionContainer;

    public GameObject inventoryContainer;

    public TextMeshProUGUI textPricae, textAmount, textHeader, textDescription;

    public void SelectItem(int itemId)
    {
        switch (itemId)
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

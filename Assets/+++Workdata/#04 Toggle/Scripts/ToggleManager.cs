using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManager : MonoBehaviour
{
    public Image image_weaponEquipt;
    public Sprite spriteFist, spriteSword, spriteBow, spriteAxe, spriteStaff;
    public void EquipWeapon(int weaponId)
    {
        switch (weaponId)
        {
            case 0: // Fist
                image_weaponEquipt.sprite = spriteFist;
                break;

            case 1: // Sword
                image_weaponEquipt.sprite = spriteSword;
                break;

            case 2: // Bow
                image_weaponEquipt.sprite = spriteBow;
                break;

            case 3: // Axe
                image_weaponEquipt.sprite = spriteAxe;
                break;

            case 4: // Staff
                image_weaponEquipt.sprite = spriteStaff;
                break;

            default:
                break;
        }
    }
}

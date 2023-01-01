using RPGCharacterAnims;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RPGCharacterAnims.Actions;
using RPGCharacterAnims.Extensions;
using RPGCharacterAnims.Lookups;
using UnityEngine.UI;

public class PlayerWeaponSwitch : MonoBehaviour
{
    public RPGInputs inputActions;
    private RPGCharacterController rpgCharacterController;
    private RPGCharacterWeaponController rpgCharacterWeaponController;

    public Image playerStateImage;

    public Sprite fistStateSprite, swordStateSprite;

    public enum PlayerState
    {
        Fist,
        Sword
    }
    public PlayerState playerState;

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Awake()
    {
        rpgCharacterController = GetComponent<RPGCharacterController>();
        rpgCharacterWeaponController = GetComponent<RPGCharacterWeaponController>();

        inputActions = new RPGInputs();

        inputActions.RPGCharacter.PullHideWeapon.performed += ctx => WeaponSwitch();
    }

    void WeaponSwitch()
    {
        var context = new SwitchWeaponContext();

        switch (playerState)
        {
            case PlayerState.Sword:
                playerState = PlayerState.Fist;

                context.type = "Switch";
                context.side = "Both";
                context.leftWeapon = Weapon.Unarmed;
                context.rightWeapon = Weapon.Unarmed;

                playerStateImage.sprite = fistStateSprite;

                rpgCharacterController.TryStartAction(HandlerTypes.SwitchWeapon, context);
                break;
            case PlayerState.Fist:
                playerState = PlayerState.Sword;

                context.type = "Switch";
                context.side = "None";
                context.leftWeapon = Weapon.Unarmed;
                context.rightWeapon = Weapon.TwoHandSword;

                playerStateImage.sprite = swordStateSprite;

                rpgCharacterController.TryStartAction(HandlerTypes.SwitchWeapon, context);
                break;
            default:
                break;
        }
    }
}

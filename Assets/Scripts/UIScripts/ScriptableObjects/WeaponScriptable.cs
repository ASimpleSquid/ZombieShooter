using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Items/Weapon", order = 2)]
public class WeaponScriptable : EquippableScriptable
{
    public WeaponStats weaponStats;

    public override void UseItem(PlayerController playerController)
    {
        if (equipped)
        {
            //unequip from invent and remove from controller
        }
        else
        {
            //invoke OnWeaponEquipped from player here for inventory
            //equip weapon from weapon holder on player controller
        }

        base.UseItem(playerController);
    }
}

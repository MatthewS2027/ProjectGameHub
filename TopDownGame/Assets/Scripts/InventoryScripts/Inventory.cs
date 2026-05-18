using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<WeaponData> weapons = new List<WeaponData>();

    public int maxSlots = 30;

    public bool AddWeapon(WeaponData weapon)
    {
        if (weapons.Count >= maxSlots)
        {
            Debug.Log("Inventory Full");
            return false;
        }

        weapons.Add(weapon);

        Debug.Log(weapon.weaponName + " added to inventory.");

        return true;
    }
}

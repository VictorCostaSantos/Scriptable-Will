using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItemComponent : MonoBehaviour
{
    [SerializeField] private Transform weaponPosition;
    [SerializeField] private Transform helmetPosition;
    [SerializeField] private Transform armorPosition;

    public void EquipWeapon(GameObject weaponPrefab)
    {
        Instantiate(weaponPrefab, weaponPosition);
    }

    public void EquipArmour(GameObject ArmorPrefab)
    {
        Instantiate(ArmorPrefab, armorPosition);
    }

    public void EquipHelmet(GameObject HelmetPrefab)
    {
        Instantiate(HelmetPrefab, helmetPosition);
    }
}

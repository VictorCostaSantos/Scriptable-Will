using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private EquipItemComponent equipComponent;

    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private int PlayerCoinBalance;

    private void Awake()
    {
        equipComponent = GetComponent<EquipItemComponent>();
        inventory.OnHandleEquipItem += EquipItemHandler;
    }

    private void EquipItemHandler(Item itemToEquip)
    {
        switch (itemToEquip.itemType)
        {
            case EItemType.Helmet:
                Debug.Log("Equipping helmet");
                equipComponent.EquipHelmet(itemToEquip.itemPrefab);
                break;
            case EItemType.Armor:
                Debug.Log("Equipping armor");
                equipComponent.EquipArmour(itemToEquip.itemPrefab);
                break;

            case EItemType.Weapon:
                Debug.Log("Equipping weapon");
                equipComponent.EquipWeapon(itemToEquip.itemPrefab);
                break;
        }
    }

    public int GetPlayerCoinBalance()
    {
        return PlayerCoinBalance;
    }
}

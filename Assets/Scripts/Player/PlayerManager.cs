using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerManager : MonoBehaviour
{
    private EquipItemComponent equipComponent;

    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private int PlayerCoinBalance;
    public TMP_Text textoTMP;

    private void Start()
    {
        
    }

    private string ToString(int v)
    {
        throw new NotImplementedException();
    }

    private void Awake()
    {
        Debug.Log(PlayerCoinBalance);
        textoTMP.text = PlayerCoinBalance.ToString();
        equipComponent = GetComponent<EquipItemComponent>();
        inventory.OnHandleEquipItem += EquipItemHandler;


    }

    private void EquipItemHandler(Item itemToEquip)
    {
        switch (itemToEquip.itemType)
        {
            case EItemType.Helmet:
                if (PlayerCoinBalance > itemToEquip.itemPrice)
                {
                    Debug.Log("Equipping helmet");
                    equipComponent.EquipHelmet(itemToEquip.itemPrefab);
                    PlayerCoinBalance -= itemToEquip.itemPrice;
                    print(PlayerCoinBalance);
                    textoTMP.text = "Coins: " + PlayerCoinBalance.ToString();
                }
                else
                {
                    print("sem money");
                }
                    break;
            case EItemType.Armor:
                if (PlayerCoinBalance > itemToEquip.itemPrice)
                {
                    Debug.Log("Equipping armor");
                    equipComponent.EquipArmour(itemToEquip.itemPrefab);
                    PlayerCoinBalance -= itemToEquip.itemPrice;
                    textoTMP.text = "Coins: " + PlayerCoinBalance.ToString();
                }
                else
                {
                    print("sem money");
                }
                break;

            case EItemType.Weapon:
                if (PlayerCoinBalance > itemToEquip.itemPrice)
                {
                    Debug.Log("Equipping weapon");
                    equipComponent.EquipWeapon(itemToEquip.itemPrefab);
                    PlayerCoinBalance -= itemToEquip.itemPrice;
                    textoTMP.text = "Coins: " + PlayerCoinBalance.ToString();
                }
                else
                {
                    print("sem money");
                }

                break;
        }
    }

    public int GetPlayerCoinBalance()
    {
        return PlayerCoinBalance;
    }
}

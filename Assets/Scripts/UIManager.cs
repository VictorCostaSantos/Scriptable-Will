using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject ShopUI;
    [SerializeField] private GameObject InventoryUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TurnUIOnOff();
        }
    }

    private void TurnUIOnOff()
    {
        if (ShopUI.active && InventoryUI.active)
        {
            InventoryUI.SetActive(false);
            ShopUI.SetActive(false);
        }
        else
        {
            InventoryUI.SetActive(true);
            ShopUI.SetActive(true);
        }
    }
}

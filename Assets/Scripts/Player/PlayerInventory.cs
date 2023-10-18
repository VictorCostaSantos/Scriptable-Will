using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private PlayerItemDisplay playerinventoryItemPrefab;
    [SerializeField] private Transform inventoryContainer;

    public event Action<Item> OnHandleEquipItem;

    private void Awake()
    {
        GameSystem.HandleItemSelled += UpdateInventory;
        PopulateInventory();
    }

    private void PopulateInventory()
    {
        foreach (Item item in inventory.items)
        {            
            InstantiatePlayerItem(item);
        }
    }

    public void UpdateInventory(Item newItem)
    {
        inventory.items.Add(newItem);
        InstantiatePlayerItem(newItem);
    }

    private void InstantiatePlayerItem(Item item)
    {
        PlayerItemDisplay playerItem = Instantiate(playerinventoryItemPrefab, inventoryContainer);
        playerItem.PopulateDisplay(item);
        playerItem.OnEquipItemButtonClicked += HandleEquipItem;
    }

    private void HandleEquipItem(Item item)
    {
        OnHandleEquipItem?.Invoke(item);
    }
}

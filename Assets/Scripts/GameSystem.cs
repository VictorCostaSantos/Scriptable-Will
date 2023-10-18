using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private ShopManager shopManager;
    [SerializeField] private PlayerInventory playerInventory;

    public static event Action<Item> HandleItemSelled;

    private void Awake()
    {
        shopManager.OnItemSelled += OnItemSelledHandler;
    }

    private void OnItemSelledHandler(Item item)
    {
        HandleItemSelled?.Invoke(item);
    }
}

using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItemDisplay : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemName;
    private Button equipButton;
    private Item storedItem;

    public event Action<Item> OnEquipItemButtonClicked;

    private void Awake()
    {
        equipButton = GetComponent<Button>();
        equipButton.onClick.AddListener(EquipItem);
    }

    public void PopulateDisplay(Item storedItem)
    {
        itemImage.sprite = storedItem.itemImage;
        itemName.text = storedItem.itemName;
        storedItem.itemState = EItemState.ToEquip;
        this.storedItem = storedItem;
    }

    private void EquipItem()
    {
        OnEquipItemButtonClicked?.Invoke(storedItem);
    }
}

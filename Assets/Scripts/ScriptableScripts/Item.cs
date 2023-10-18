using UnityEngine;

[CreateAssetMenu (fileName = "EquippedItem", menuName = "ScriptableAssets/New Item")]
public class Item : ScriptableObject
{
    public GameObject itemPrefab;
    public Sprite itemImage;
    public int itemPrice;
    public string itemName;
    public EItemType itemType;
    public EItemState itemState;
}


public enum EItemType
{
    Helmet,
    Armor,
    Weapon
}

public enum EItemState
{
    ToEquip,
    ToBuy,
    Equipped
}
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Item")]
public class scr_ItemData : ScriptableObject
{
    public int id;
    public string itemName;
    public int amount;
    public int value;
    public Sprite icon;
    public ItemType ItemType;
}

public enum ItemType
{
    Potion,
    Sword,
    Coin
}

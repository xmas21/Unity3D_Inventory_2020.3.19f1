using UnityEngine;
using UnityEngine.UI;

public class scr_ItemUI : MonoBehaviour
{
    [Header("道具資料")] public scr_ItemData item;
    [Header("移除按鈕")] public Button remove_Btn;
    [Header("使用按鈕")] public Button use_Btn;

    void Awake()
    {
        remove_Btn.onClick.AddListener(Remove);
        use_Btn.onClick.AddListener(UseItem);
    }

    /// <summary>
    /// 移除道具
    /// </summary>
    void Remove()
    {
        scr_Inventory.instance.RemoveItem(item);
        Destroy(gameObject);
    }

    /// <summary>
    /// 使用道具
    /// </summary>
    void UseItem()
    {
        switch (item.ItemType)
        {
            case ItemType.Potion:
                scr_Player.instance.hp += item.value;
                Remove();
                break;
            case ItemType.Sword:
                break;
            case ItemType.Coin:
                scr_Player.instance.coin += item.value;
                Remove();
                break;
        }
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Inventory : MonoBehaviour
{
    public static scr_Inventory instance;
    [Header("道具 資料清單")] public List<scr_ItemData> items = new List<scr_ItemData>();
    [Header("道具 欄位")] public Transform item_Content;
    [Header("道具 預置物")] public GameObject item_Prefab;

    void Awake()
    {
        instance = this;
    }

    /// <summary>
    /// 增加道具
    /// </summary>
    /// <param name="item">道具</param>
    public void AddItem(scr_ItemData item)
    {
        items.Add(item);
    }

    /// <summary>
    /// 移除道具
    /// </summary>
    /// <param name="item">道具</param>
    public void RemoveItem(scr_ItemData item)
    {
        items.Remove(item);
    }

    /// <summary>
    /// 道具列表
    /// </summary>
    public void ItemList()
    {
        foreach (Transform item in item_Content)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in items)
        {
            GameObject _obj = Instantiate(item_Prefab, item_Content);
            var _itemText = _obj.transform.Find("Name").GetComponent<Text>();
            var _itemIcon = _obj.transform.Find("Icon").GetComponent<Image>();
            var _itemData = _obj.GetComponent<scr_ItemUI>();

            _itemText.text = item.itemName;
            _itemIcon.sprite = item.icon;
            _itemData.item = item;
        }
    }
}

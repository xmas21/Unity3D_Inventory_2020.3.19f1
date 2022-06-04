using UnityEngine;

public class scr_ItemController : MonoBehaviour
{
    [Header("道具資料")] public scr_ItemData item;

    void OnMouseDown()
    {
        Pickup();
    }

    /// <summary>
    /// 撿道具
    /// </summary>
    void Pickup()
    {
        scr_Inventory.instance.AddItem(item);
        Destroy(gameObject);
    }
}

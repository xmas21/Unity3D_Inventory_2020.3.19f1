using UnityEngine;

public class scr_ItemController : MonoBehaviour
{
    [Header("�D����")] public scr_ItemData item;

    void OnMouseDown()
    {
        Pickup();
    }

    /// <summary>
    /// �߹D��
    /// </summary>
    void Pickup()
    {
        scr_Inventory.instance.AddItem(item);
        Destroy(gameObject);
    }
}

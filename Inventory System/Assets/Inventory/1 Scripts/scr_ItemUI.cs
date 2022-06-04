using UnityEngine;
using UnityEngine.UI;

public class scr_ItemUI : MonoBehaviour
{
    [Header("�D����")] public scr_ItemData item;
    [Header("�������s")] public Button remove_Btn;
    [Header("�ϥΫ��s")] public Button use_Btn;

    void Awake()
    {
        remove_Btn.onClick.AddListener(Remove);
        use_Btn.onClick.AddListener(UseItem);
    }

    /// <summary>
    /// �����D��
    /// </summary>
    void Remove()
    {
        scr_Inventory.instance.RemoveItem(item);
        Destroy(gameObject);
    }

    /// <summary>
    /// �ϥιD��
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

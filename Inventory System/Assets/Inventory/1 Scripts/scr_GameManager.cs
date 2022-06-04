using UnityEngine;

public class scr_GameManager : MonoBehaviour
{
    [SerializeField] [Header("背包畫面")] GameObject Inventory_page;

    /// <summary>
    /// 開關背包
    /// </summary>
    /// <param name="_bag">開關</param>
    public void InventoryPage(bool _bag)
    {
        Inventory_page.SetActive(_bag);
    }
}

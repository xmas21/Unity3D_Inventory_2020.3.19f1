using UnityEngine;

public class scr_GameManager : MonoBehaviour
{
    [SerializeField] [Header("�I�]�e��")] GameObject Inventory_page;

    /// <summary>
    /// �}���I�]
    /// </summary>
    /// <param name="_bag">�}��</param>
    public void InventoryPage(bool _bag)
    {
        Inventory_page.SetActive(_bag);
    }
}

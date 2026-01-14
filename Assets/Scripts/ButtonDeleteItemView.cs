using UnityEngine;
using UnityEngine.UI;

public class ButtonDeleteItemView : MonoBehaviour
{
    [SerializeField] Button button;

    private InventoryController _inventoryController;

    public void Initialize(InventoryController inventoryController)
    {
        _inventoryController = inventoryController;
    }

    void OnEnable()
    {
        button.onClick.AddListener(DeleteItem);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(DeleteItem);
    }

    private void DeleteItem()
    {
        _inventoryController.DeleteItem();
    }
}

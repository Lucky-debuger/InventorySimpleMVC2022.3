using UnityEngine;
using UnityEngine.UI;

public class ButtonAddSlotView : MonoBehaviour
{
    private InventoryController _inventoryController;
    [SerializeField] private Button button;

    public void Initialize(InventoryController inventoryController)
    {
        _inventoryController = inventoryController;
    }

    private void OnEnable()
    {
        button.onClick.AddListener(AddSlotButton);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(AddSlotButton);
    }

    private void AddSlotButton()
    {
        _inventoryController.AddSelectedItem();
    }
}

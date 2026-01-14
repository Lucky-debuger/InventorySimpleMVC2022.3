using System;
using UnityEngine;

public class InventoryController
{
    private InventoryModel _inventoryModel;
    private ItemModel _selectedInventoryItem;
    private ItemModel _selectedAddItem;

    public event Action<ItemModel> OnItemAdded;
    public event Action<ItemModel> OnItemDeleted;

    public void SelectInventorySlot(ItemModel item)
    {
        _selectedInventoryItem = item;
    }

    public void SelectAddSlot(ItemModel item)
    {
        _selectedAddItem = item;
    }

    public InventoryController(InventoryModel inventoryModel)
    {
        _inventoryModel = inventoryModel;
    }

    public void AddSelectedItem()
    {
        if (_selectedAddItem == null) return;

        _inventoryModel.AddItem(_selectedAddItem);
        OnItemAdded?.Invoke(_selectedAddItem);
    }

    public void DeleteItem()
    {
        if (_selectedInventoryItem == null) return;

        _inventoryModel.DeleteItem(_selectedInventoryItem);
        OnItemDeleted?.Invoke(_selectedInventoryItem);
    }
}

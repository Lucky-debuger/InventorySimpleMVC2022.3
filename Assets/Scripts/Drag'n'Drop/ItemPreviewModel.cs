using UnityEngine;

[CreateAssetMenu(fileName = "ItemPreview", menuName = "ScriptableObjects/Inventory/ItemPreview", order = 2)]
public class ItemPreviewModel : ScriptableObject
{
    [SerializeField] private string itemPreviewName;
    [SerializeField] private Sprite itemPreviewIcon;

    public string Name => itemPreviewName; // [ ] Что это "=>" и почему не "="? Публичные поля нельзя изменять в runtime?
    public Sprite Icon => itemPreviewIcon; // [ ] Это поле, а не свойство?
    // public string Name { get { return itemPreviewName; } }

}

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemPreview : MonoBehaviour
{
    private ItemPreviewModel _itemPreviewModel;
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text text;


    public void Initialize(ItemPreviewModel itemPreviewModel)
    {
        _itemPreviewModel = itemPreviewModel;

        image.sprite = _itemPreviewModel.Icon;
        text.text = _itemPreviewModel.Name;
    }
}

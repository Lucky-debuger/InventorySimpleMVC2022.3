using UnityEngine;
using UnityEngine.EventSystems;

public class AddItemButton : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private ItemPreviewModel itemPreviewModel;
    [SerializeField] private Canvas parentCanvas;
    [SerializeField] private ItemPreview itemPreviewPrefab;

    private ItemPreview _flyingPreview;

    public void OnBeginDrag(PointerEventData eventData)
    {
        _flyingPreview = Instantiate(itemPreviewPrefab, parentCanvas.transform);
        _flyingPreview.Initialize(itemPreviewModel);
        _flyingPreview.transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        _flyingPreview.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(_flyingPreview.gameObject);
    }
}

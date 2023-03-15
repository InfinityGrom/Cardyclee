using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardController : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{
    private Image image;
    private Vector3 offset;
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(transform.root);
        image.raycastTarget = false;
        offset = Input.mousePosition-this.transform.position;

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition-offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(CardManager.LastEnteredDropZone);
        image.raycastTarget = true;
    }
}

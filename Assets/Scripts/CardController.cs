using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public Vector3 offset;
    public enum Type { ENEMY, FRIENDLY };
    public Type typeOfCard = Type.FRIENDLY;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        //This line fixes the mouse teleportation to the center of the card when clicked
        offset = Input.mousePosition-this.transform.position;

    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition-offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //transform.position=Input.mousePosition;
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}

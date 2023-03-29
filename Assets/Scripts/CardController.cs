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

    //GameObject placeholder = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //placeholder = new GameObject();
        //placeholder.transform.SetParent(this.transform.parent);

        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        //LayoutElement le = placeholder.AddComponent<LayoutElement>();
        //le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        //le.preferredWidth = this. GetComponent<LayoutElement>().preferredWidth;
        //le.flexibleHeight = 0;
        //le.flexibleWidth = 0;

        //placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
        //This line fixes the mouse teleportation to the center of the card when clicked
        offset = Input.mousePosition-this.transform.position;
        
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition-offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        //Destroy(placeholder);
    }
}

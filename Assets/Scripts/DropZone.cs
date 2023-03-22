using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public CardController.Type typeOfCard;
    public void OnDrop(PointerEventData eventData)
    {
        CardController c = eventData.pointerDrag.GetComponent<CardController>();
        if (c != null )
        {
            if(typeOfCard == c.typeOfCard)
            {
                c.parentToReturnTo = this.transform;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public CardController.Type typeOfCard;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag==null) return;

        CardController c = eventData.pointerDrag.GetComponent<CardController>();

        if (c != null)
        {
            if (typeOfCard == c.typeOfCard)
            {
                c.placeholderParent = this.transform;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;

        CardController c = eventData.pointerDrag.GetComponent<CardController>();

        if ((c != null)&&(c.placeholderParent == this.transform))
        {
            if (typeOfCard == c.typeOfCard)
            {
                c.placeholderParent = c.parentToReturnTo;
            }
        }
    }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public bool occupied;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null && !occupied)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().hasValidTarget = true;
            eventData.pointerDrag.GetComponent<DragDrop>().slot = this;
            occupied = true;
        }
    }
}

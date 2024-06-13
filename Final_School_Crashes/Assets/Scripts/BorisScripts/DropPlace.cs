using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Chairs draggable = eventData.pointerDrag.GetComponent<Chairs>();
        if (draggable != null && eventData.pointerDrag.CompareTag("Chairs"))
        {
            draggable.transform.SetParent(transform);
            draggable.transform.position = transform.position;
        }
        else
        {
            draggable.transform.position = draggable.startPos;
        }
    }
}

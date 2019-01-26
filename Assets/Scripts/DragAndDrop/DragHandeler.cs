using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDrag;
    Vector3 startPosition;
    Transform startParent;

    #region IBeginDragHandler implementation
    public void OnBeginDrag (PointerEventData eventData) {
        itemBeingDrag = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    #endregion

    #region IDragHandler implementation
    public void OnDrag (PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }
    #endregion

    #region IEndDragHandler implementation
    public void OnEndDrag (PointerEventData eventData) {
        itemBeingDrag = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent != startParent) {
            transform.position = startPosition;
        }
        transform.position = startPosition;
    }
    #endregion

}
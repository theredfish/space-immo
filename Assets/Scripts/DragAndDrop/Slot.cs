using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{

    [SerializeField]
    GameObject Planet;
    public GameObject item {
        get {
             if (transform.childCount > 0) {
                 return transform.GetChild(0).gameObject;
                
             }
             return null;
        }
    }

    #region IDropHandler implementation
    public void OnDrop (PointerEventData eventData) {
        if (!item) {
            Debug.Log(DragHandeler.itemBeingDrag.gameObject.tag);
            Planet.GetComponent<PlanetManager>().addElementsToThePlanet(DragHandeler.itemBeingDrag.gameObject.tag);
        }
    }
    #endregion
}

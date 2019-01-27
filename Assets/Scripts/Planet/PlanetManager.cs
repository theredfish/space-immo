using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{

    const string MOUNTAIN = "Mountain";
    const string WATER = "Water";
    const string TREE = "Tree";
    //Parent Of the moutains
    Transform mountains;
    bool isMountainsCompleted;
    //Parent Of the moutains
    Transform waters;
    //Parent Of the moutains
    bool isWatersCompleted;
    Transform trees;
    bool isTreesCompleted;

    bool isCompleted;
    void Start()
    {
        isCompleted = false;
        mountains = transform.Find("Mountains");
        waters = transform.Find("Waters");
        trees = transform.Find("Trees");
    }

    void Update()
    {
        transform.Rotate(0, 0, 15 * Time.deltaTime);
    }

    public void addElementsToThePlanet(string tag)
    {
        refreshIsCompleted();
        switch (tag)
        {
            case MOUNTAIN:
                addRandomTypeElement(mountains);
                break;
            case WATER:
                addRandomTypeElement(waters);
                break;
            case TREE:
                addRandomTypeElement(trees);
                break;
            default:
                Debug.Log("0 element ajouter");
                break;

        }
    }

    void addRandomTypeElement(Transform elementType)
    {
        if (!isAllChildrenOfAnElementTypeActive(elementType))
        {
            int randomChildIndex = Random.Range(0, elementType.childCount - 1);
            while (elementType.GetChild(randomChildIndex).gameObject.activeSelf)
            {
                randomChildIndex = Random.Range(0, elementType.childCount - 1);
            }
            elementType.GetChild(randomChildIndex).gameObject.SetActive(true);
            refreshIsCompleted();
        }
    }

    bool isAllChildrenOfAnElementTypeActive(Transform elementType)
    {

        for (int i = 0; i < elementType.childCount; i++)
        {
            if (elementType.GetChild(i).gameObject.activeSelf == false)
            {
                return false;
            }
        }
        return true;
    }

    void refreshIsCompleted()
    {
        isMountainsCompleted = isAllChildrenOfAnElementTypeActive(mountains);
        isWatersCompleted = isAllChildrenOfAnElementTypeActive(waters);
        isTreesCompleted = isAllChildrenOfAnElementTypeActive(trees);

        if (isMountainsCompleted == true && isWatersCompleted == true && isTreesCompleted == true)
        {
            isCompleted = true;
            Debug.Log("PLANET COMPLETED !!!!");
        }
    }
}

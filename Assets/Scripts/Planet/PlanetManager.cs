using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetManager : MonoBehaviour
{

    const string MOUNTAIN = "Mountain";
    const string WATER = "Water";
    const string TREE = "Tree";
    const string HERB = "Herb";
    const string FLOWER = "Flower";
    //Parent Of the moutains
    Transform mountains;
    bool isMountainsCompleted;
    //Parent Of the moutains
    Transform waters;
    //Parent Of the moutains
    bool isWatersCompleted;
    Transform trees;
    bool isTreesCompleted;

    Transform herbs;
    bool isHerbsCompleted;

    Transform flowers;
    bool isFlowersCompleted;
    //Parent Of the moutains
    //Parent Of the moutains

    bool isCompleted;

    GameManager gameManager;

    public GameObject BackToMainMenuBoutton; 
    void Awake() {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {
        isCompleted = false;
        mountains = transform.Find("Mountains");
        waters = transform.Find("Waters");
        trees = transform.Find("Trees");
        flowers = transform.Find("Flowers");
        herbs = transform.Find("Herbs");
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
            case HERB:
                addRandomTypeElement(herbs);
                break;
            case FLOWER:
                addRandomTypeElement(flowers);
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
            int randomChildIndex = Random.Range(0, elementType.childCount);
            while (elementType.GetChild(randomChildIndex).gameObject.activeSelf)
            {
                Debug.Log(randomChildIndex);
                randomChildIndex = Random.Range(0, elementType.childCount);
            }
            elementType.GetChild(randomChildIndex).gameObject.SetActive(true);
            refreshIsCompleted();
        }
    }

    bool isAllChildrenOfAnElementTypeActive(Transform elementType)
    {
        Debug.Log(elementType);
        Debug.Log(elementType.childCount);
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
        isHerbsCompleted = isAllChildrenOfAnElementTypeActive(herbs);
        isFlowersCompleted = isAllChildrenOfAnElementTypeActive(flowers);

        if (isMountainsCompleted == true && isWatersCompleted == true && isTreesCompleted == true 
        && isHerbsCompleted == true && isFlowersCompleted == true)
        {
            isCompleted = true;
            Debug.Log("PLANET COMPLETED !!!!");
            GameObject findTimeLeft = GameObject.FindGameObjectWithTag("TimeLeft");
            Text labelTimeLeft = findTimeLeft.GetComponent<Text>();
            gameManager.Win(labelTimeLeft);
            BackToMainMenuBoutton.SetActive(true);
        }
    }
}

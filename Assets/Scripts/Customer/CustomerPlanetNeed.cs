using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerPlanetNeed : MonoBehaviour
{
    public int water = 0;
    public int tree = 0;
    public int mountains = 0;
    Renderer m_Renderer;
    public Color color = Color.black;

    void Awake()
    {
        //Fetch the Renderer component of the GameObject
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.material.color = color;
    }
}

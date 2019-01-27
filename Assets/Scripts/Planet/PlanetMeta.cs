using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMeta : MonoBehaviour
{
    public int waterFirstType = 0;
    public int waterSecondType = 0;
    public int trees = 0;

    public int mountainsFirstType = 0;

    public int mountainsSecondType = 0;

    Renderer m_Renderer;
    public Color color = Color.black;

    void Awake()
    {
        //Fetch the Renderer component of the GameObject
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.material.color = color;
    }
}

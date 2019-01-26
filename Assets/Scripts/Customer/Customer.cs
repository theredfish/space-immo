using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public CustomerPlanetNeed need;

    void Awake()
    {
        need = GetComponent<CustomerPlanetNeed>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    public static BaseManager instance = null;
    // Start is called before the first frame update
    void Awake()
    {
        //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(this.gameObject);
    }
}

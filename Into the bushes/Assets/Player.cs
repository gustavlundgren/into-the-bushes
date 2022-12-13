using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool first;

    
    void Start()
    {
        first = GameObject.Find("Game").GetComponent<Game>().firstLoad;

        if (first)
        {
            DontDestroyOnLoad(this);

            first = false;
        }
    }
}

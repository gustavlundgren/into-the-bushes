using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Bed : MonoBehaviour
{

    public GameObject game;
    public Game gameScript;

    void Start()
    {
        gameScript = game.GetComponent<Game>();

    }

        void OnTriggerStay2D(Collider2D other)
    {
        print("enter");
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Bed : MonoBehaviour
{
    public GameObject game;
    private Game gameScript;

    private bool inBed;

    void Start()
    {
        game = GameObject.Find("Game");
        gameScript = game.GetComponent<Game>();
    }

    private void Update()
    {
        if (inBed && Input.GetKeyDown("e") && !gameScript.day)
        {
            gameScript.day = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inBed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inBed = false;
        }
    }
}

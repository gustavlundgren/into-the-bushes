using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Bed : MonoBehaviour
{

    public GameObject game;
    public Game gameScript;

    private bool inBed;

    void Start()
    {
        game = GameObject.Find("Game");
        gameScript = game.GetComponent<Game>();
    }

    void Update()
    {
        if (inBed && !gameScript.day && Input.GetKeyDown("e"))
        {
            gameScript.day = true;
            gameScript.TimeOfDay = gameScript.dayLenght;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inBed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inBed = false;
        }
    }
}

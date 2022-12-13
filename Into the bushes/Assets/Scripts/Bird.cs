using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private bool isCatched = false;
    public float difficulty = 0.2f;


    void Update()
    {
        if (isCatched && Input.GetKeyDown("e"))
        {
            print("Catch");

           if (Random.Range(0f, 1f) < difficulty)
           {
                Destroy(gameObject);
           }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isCatched = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isCatched = false;
        }
    }

}

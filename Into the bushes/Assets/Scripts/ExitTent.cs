using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class ExitTent : MonoBehaviour
{
    public GameObject levelLoader;

    private bool changeScene;

    void Update()
    {
        if (Input.GetKeyDown("e") && changeScene)
        {
            levelLoader.GetComponent<sceneSwith>().LoadNextLevel(0);
        }

        if (Input.GetKeyDown("e"))
        {
           
        } 
        
        print("e");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            changeScene = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            changeScene = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class EntryCheck : MonoBehaviour
{
    sceneSwith sceneSwither;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // sceneSwither = GameObject.FindGameObjectsWithTag("LevelLoader").GetComponenet<sceneSwith>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetAxis("Submit") == 1)
        {
            print("E");
        }
    }
}

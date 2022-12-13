using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Frog : MonoBehaviour
{
    [SerializeField] public GameObject player;
    public float speed = 3f;

    public Vector2 playerpos; 
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerpos = player.transform.position; 

        if (Vector2.Distance(transform.position, player.transform.position) < 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, -speed * Time.deltaTime);
        }
        
    }
}

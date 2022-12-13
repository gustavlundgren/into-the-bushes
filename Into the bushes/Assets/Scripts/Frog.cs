using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Frog : MonoBehaviour
{
    public bool jumpReady;
    public float jumpCD = 1.5f;
    public float jumpCDcurrent = 0f;


    public GameObject player;
    public float speed = 500f;
    private Vector3 dirToPlayer;
    private Vector3 newPos;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        newPos = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        dirToPlayer = transform.position - player.transform.position;

        if (Vector3.Distance(transform.position, player.transform.position) < 4 && jumpReady)
        {
            jumpCDcurrent = 0f;

            
            newPos = transform.position + dirToPlayer;

            transform.Rotate (new Vector3(0,0,3) * Time.deltaTime);
        }

        if (jumpCDcurrent >= jumpCD)
        {
            jumpReady = true;
        }
        else
        {
            jumpCDcurrent += Time.deltaTime;
            jumpReady = false;
            jumpCDcurrent = Mathf.Clamp(jumpCDcurrent, 0f, jumpCD);
        }
        
        transform.position = Vector3.MoveTowards(transform.position, newPos, speed * Time.deltaTime);
    }
}

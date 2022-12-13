using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Frog : MonoBehaviour
{
    public GameObject player;
    public float speed = 500f;

    public bool jumpReady;
    public float jumpCD = 1.5f;
    public float jumpCDcurrent = 0.0f;

    private Rigidbody2D rigidbody2d;

    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        target = transform.position;

        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
 
        if(jumpCDcurrent >= jumpCD)
        {
            jumpReady = true;
        } else
        {
            jumpCDcurrent += Time.deltaTime;
            jumpReady = false;
            jumpCDcurrent = Mathf.Clamp(jumpCDcurrent, 0.0f, jumpCD);
        }

        

        if (Vector3.Distance(transform.position, player.transform.position) < 4 && jumpReady)
        {
            target = new Vector3(5, 5, transform.position.z);

            print("target " + target);
            print("pos " + transform.position);
            jumpCDcurrent = 0.0f;
        }

        //print(Time.deltaTime);
        Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 target;
    private Camera cam;

    public GameObject player;

    void Start()
    {
        target = transform.position;
        cam = Camera.main;

        player = GameObject.Find("Player");
    }

    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            target = cam.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        */

        target = player.transform.position;
        target.z = transform.position.z;

        transform.position = target;
    }
}

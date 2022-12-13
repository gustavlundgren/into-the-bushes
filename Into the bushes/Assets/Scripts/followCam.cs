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
        target = player.transform.position;
        target.z = transform.position.z;

        transform.position = target;
    }
}

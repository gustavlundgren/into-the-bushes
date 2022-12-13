using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 target;

    private bool first;

    public GameObject player;

    void Start()
    {
        first = GameObject.Find("Game").GetComponent<Game>().firstLoad;

        target = transform.position;

        player = GameObject.FindGameObjectWithTag("Player");

        if (first)
        {
            DontDestroyOnLoad(this);

            first = false;
        }
    }

    void Update()
    {
        target = player.transform.position;
        target.z = transform.position.z;

        transform.position = target;
    }
}

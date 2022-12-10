using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 playerPos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = Camera.main.WorldToViewportPoint(player.transform.position);

        if (playerPos.x > 0.51)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 15, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }

        if (playerPos.x < 0.49)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 15, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }

        if (playerPos.y > 0.7)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 15, transform.position.z), speed * Time.deltaTime);
        }

        if (playerPos.y < 0.69)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 15, transform.position.z), speed * Time.deltaTime);
        }
    }
}

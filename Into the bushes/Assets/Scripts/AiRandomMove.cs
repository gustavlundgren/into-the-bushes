using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRandomMove : MonoBehaviour
{
    public float speed = 5f;
    public float moveTime = 4f;

    private Vector3 target;


    private void Start()
    {
        target = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (target == transform.position)
        {
            new WaitForSeconds(2);

            target = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 0f), transform.position.z);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }
}
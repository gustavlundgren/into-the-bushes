using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{

    public float speed = 5f;
    private Vector3 target;
    private Camera cam;
    [SerializeField] GameObject ring;


    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject[] rings = GameObject.FindGameObjectsWithTag("Ring");
            foreach (GameObject ring in rings)
            GameObject.Destroy(ring);

            target = cam.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            Instantiate(ring, target, Quaternion.identity);
            target.y += 1.5f;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}

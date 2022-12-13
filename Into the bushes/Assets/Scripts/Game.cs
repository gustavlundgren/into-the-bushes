using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float dayLenght = 10f;
    private float TimeOfDay;
    public bool day = true;

    public GameObject player;

    public GameObject bird;
    public int birdCount;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;

        TimeOfDay = dayLenght;

        for (int i = 0; i < birdCount; i++)
        {
            Instantiate(bird, new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 0f), transform.position.z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        TimeOfDay -= Time.deltaTime % 60;

        if(TimeOfDay < 0)
        {
            TimeOfDay = dayLenght;

            day = !day;
        }

        if (day)
        {
            cam.backgroundColor = Color.blue;
        }
        else
        {
            cam.backgroundColor = Color.black;
        }


        print(player.transform.position);
    }
}

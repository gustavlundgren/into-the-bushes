using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public float dayLenght = 10f;
    public float TimeOfDay;
    public bool day;

    public GameObject bird;
    public int birdCount;

    public GameObject frog;
    public int frogCount;

    public bool firstLoad = true;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {

        firstLoad = GameObject.Find("Game").GetComponent<Game>().firstLoad;

        cam = Camera.main;      

        TimeOfDay = dayLenght;

        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            for (int i = 0; i < birdCount; i++)
            {
                Instantiate(bird, new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 0f), transform.position.z), Quaternion.identity);
            }

            for (int i = 0; i < frogCount; i++)
            {
                Instantiate(frog, new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 0f), transform.position.z), Quaternion.identity);
            }
        }


        if (firstLoad)
        {
            DontDestroyOnLoad(this);

            firstLoad = false;
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

        if (!day)
        {
            cam.backgroundColor = Color.black;
        }
    }
}

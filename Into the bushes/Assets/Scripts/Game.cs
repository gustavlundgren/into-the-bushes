using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    private float dayLenght = 200;
    private float TimeOfDay;
    public bool day = true;

    public GameObject bird;
    public int birdCount;


    // Start is called before the first frame update
    void Start()
    {
        TimeOfDay = dayLenght;
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
            Camera.main.backgroundColor = Color.blue;
        }
        else
        {
            Camera.main.backgroundColor = Color.black;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            for (int i = 0; i < birdCount; i++)
            {
                Instantiate(bird, new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 0f), transform.position.z), Quaternion.identity);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float dayLenght = 10f;
    private float TimeOfDay;
    public bool day = true;
    

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

            print(day);
        }
    }
}

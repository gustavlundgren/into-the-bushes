using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class EntryCheck : MonoBehaviour
{
    public GameObject levelLoad;

    void OnCollisionStay2D(Collision2D collision)
    {
        levelLoad.GetComponent<sceneSwith>().LoadNextLevel(1);
    }
}

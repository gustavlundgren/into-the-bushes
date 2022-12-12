using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class ExitTent : MonoBehaviour
{
    public GameObject levelLoad;

    void OnCollisionStay2D(Collision2D collision)
    {
        levelLoad.GetComponent<sceneSwith>().LoadNextLevel(0);
    }
}

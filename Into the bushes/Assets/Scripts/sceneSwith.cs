using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwith : MonoBehaviour
{
    public Animator transition;

    private Camera cam;

    public float transitionTime = 1f;

    void Start()
    {
        cam = Camera.main;
    }


    public void LoadNextLevel(int level)
    {
        StartCoroutine(LoadLevel(level));

        cam.transform.position = new Vector3(0, 0, -10);
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}

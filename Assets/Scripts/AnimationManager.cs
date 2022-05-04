using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationManager : MonoBehaviour
{
    public float timeLeft;
    public int sceneIndex;
    void Start()
    {
        timeLeft = 6f;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

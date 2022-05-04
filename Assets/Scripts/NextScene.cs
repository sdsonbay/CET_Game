using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    public Button startButton;
    public int sceneIndex;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartButtonTapped()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

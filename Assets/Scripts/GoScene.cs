using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour
{
    public Button button;
    public int goToScene;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(goToScene);
    }
}

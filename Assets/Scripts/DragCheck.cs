using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragCheck : MonoBehaviour
{
    public Button nextButton;
    public int goToSceneAtIndex;
    public string correctAnswer;
    public int correctScene;
    public int wrongScene;
    void Start()
    {
        
    }

    void Update()
    {
        if (ResetPlace.Instance.selectedImage.transform.name == correctAnswer)
        {
            goToSceneAtIndex = correctScene;
        }
        else
        {
            goToSceneAtIndex = wrongScene;
        }
    }
    public void NextButtonTapped()
    {
        SceneManager.LoadScene(goToSceneAtIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GoToReportScreen : MonoBehaviour
{
    public Button startButton;
    public int sceneIndex;
    public Button checkButton;
    public TMP_Dropdown redDropdown;
    public TMP_Dropdown greenDropdown;

    void Start()
    {

    }

    void Update()
    {
        if (redDropdown.value == 1 && greenDropdown.value == 2)
        {
            sceneIndex = 6;
        }
        else
        {
            sceneIndex = 7;
        }
    }

    public void GoToNegativeFeedback()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void GoToPositiveFeedback()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void StartButtonTapped()
    {
        if (redDropdown.value == 1 && greenDropdown.value == 2)
        {
            GoToPositiveFeedback();
        }
        else
        {
            GoToNegativeFeedback();
        }
    }
}

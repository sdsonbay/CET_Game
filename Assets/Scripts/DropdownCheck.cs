using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DropdownCheck : MonoBehaviour
{
    public int sceneIndex;
    public Button checkButton;
    public TMP_Dropdown dropdown;

    void Start()
    {

    }

    void Update()
    {
        if (dropdown.value == 2)
        {
            sceneIndex = 9;
        }
        else
        {
            sceneIndex = 10;
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
        if (dropdown.value == 2)
        {
            GoToPositiveFeedback();
        }
        else
        {
            GoToNegativeFeedback();
        }
    }
}

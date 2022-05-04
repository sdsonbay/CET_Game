using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextIncludingName : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button nextButton;
    public int goToSceneAtIndex;
    void Start()
    {
        
    }

    void Update()
    {
        GameManager.Instance.username = inputField.text;
        if (inputField.text == null || inputField.text == "")
        {
            goToSceneAtIndex = 25;
        }
        else
        {
            goToSceneAtIndex = 26;
        }
    }

    public void NextButtonClicked()
    {
        SceneManager.LoadScene(goToSceneAtIndex);
    }
}

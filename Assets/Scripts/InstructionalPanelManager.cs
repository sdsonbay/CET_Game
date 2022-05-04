using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class InstructionalPanelManager : MonoBehaviour
{
    public int counter;
    public int sceneIndex;
    public TextMeshProUGUI instructionalText;
    public string[] instructionalTexts;
    public Button continueButton;

    void Start()
    {
        counter = 0;
        instructionalText.text = instructionalTexts[counter];
    }

    void Update()
    {
        if (counter > instructionalTexts.Length - 1)
        {
            GoToNextScene();
        }
        if (counter > instructionalTexts.Length - 1)
        {
            counter = 0;
        }
    }


    public void ChangeInstructionalText()
    {
        instructionalText.text = instructionalTexts[counter];

    }
    public void ContinueButtonTapped()
    {
        counter += 1;
        ChangeInstructionalText();

    }
    public void GoToNextScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }

}

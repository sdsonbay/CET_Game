using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class SpeechManager : MonoBehaviour
{
    public int sceneIndex;
    public int tapCounter;
    public TextMeshProUGUI speechBubbleText;
    public string[] speechTexts;
    public Button continueButton;

    void Start()
    {
        tapCounter = 0;
        speechBubbleText.text = speechTexts[tapCounter];
    }

    void Update()
    {
        if (tapCounter > speechTexts.Length - 1)
        {
            GoToNextScene();
        }
        if (tapCounter > speechTexts.Length - 1)
        {
            tapCounter = 0;
        }
    }

    
    public void ChangeSpeechText()
    {
        speechBubbleText.text = speechTexts[tapCounter];
        
    }
    public void ContinueButtonTapped()
    {
        tapCounter += 1;
        ChangeSpeechText();
        
    }
    public void GoToNextScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

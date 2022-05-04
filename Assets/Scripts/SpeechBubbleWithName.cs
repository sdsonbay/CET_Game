using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeechBubbleWithName : MonoBehaviour
{
    public TextMeshProUGUI bubbleText;
    void Start()
    {
        bubbleText.text = "Hadi gel " + GameManager.Instance.username + ". Seninle bir tura çýkalým. Bakalým her þey yolunda mý?";
    }

    void Update()
    {
        
    }
}

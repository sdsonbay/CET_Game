using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
    
    public GameObject aboutPanel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OpenPanelStatus()
    {
        aboutPanel.SetActive(true);
    }
    public void ClosePanelStatus()
    {
        aboutPanel.SetActive(false);
    }
}

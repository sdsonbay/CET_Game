using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetPlace : MonoBehaviour
{
    private static ResetPlace _instance;
    public static ResetPlace Instance
    {
        get
        {
            return _instance;
        }
    }

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;

    private Vector2 startPos1;
    private Vector2 startPos2;
    private Vector2 startPos3;
    private Vector2 startPos4;

    public Image slot;

    public Image selectedImage;
    
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        startPos1 = image1.transform.position;
        startPos2 = image2.transform.position;
        startPos3 = image3.transform.position;
        startPos4 = image4.transform.position;
    }

    void Update()
    {
        
    }
    public void ResetImagePlaces()
    {
        selectedImage = null;
        image1.transform.position = startPos1;
        image2.transform.position = startPos2;
        image3.transform.position = startPos3;
        image4.transform.position = startPos4;

    }
}

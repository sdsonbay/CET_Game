using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{
    public Image slot;
    public Image thisImage;
        
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnItemClick()
    {
        ResetPlace.Instance.selectedImage = thisImage;
        transform.position = slot.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_script : MonoBehaviour
{
    // Reference to the Image GameObject
    public RawImage myImage;

    // Method to handle button click
    public void OnButtonClick()
    {
        // Check if the Image GameObject is not null
        if (myImage != null)
        {
            // Set the Image GameObject to active
            myImage.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("Image reference is not set!");
        }
    }
}

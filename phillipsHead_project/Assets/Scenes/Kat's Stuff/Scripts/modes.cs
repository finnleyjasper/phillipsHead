using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class modes : MonoBehaviour
{
    public RawImage imageToToggle;

    // This method will be called when the toggle button is clicked
    public void ToggleImageVisibility()
    {
        if (imageToToggle != null)
        {
            // Toggle the image's visibility
            imageToToggle.enabled = !imageToToggle.enabled;
        }
        else
        {
            Debug.LogWarning("Image to toggle is not assigned!");
        }
    }
}
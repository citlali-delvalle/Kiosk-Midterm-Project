using UnityEngine;
using UnityEngine.UI; // Required for working with UI elements

public class ToggleObjectVisibility : MonoBehaviour
{
    // Drag the GameObject you want to control into this field in the Inspector
    public GameObject objectToToggle;

    // Public function to be called by the Button's OnClick event
    public void ToggleVisibility()
    {
        if (objectToToggle != null)
        {
            // Toggle the active state: if it's active, set it to inactive, and vice versa
            objectToToggle.SetActive(!objectToToggle.activeSelf);
        }
    }
}
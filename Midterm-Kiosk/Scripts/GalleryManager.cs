using UnityEngine;
using UnityEngine.UI;

public class GalleryManager : MonoBehaviour
{
    public Sprite[] galleryImages; // Array to hold your images
    public Image displayImage;     // Reference to the UI Image component
    private int currentIndex = 0;

    void Start()
    {
        if (galleryImages.Length > 0)
        {
            displayImage.sprite = galleryImages[currentIndex];
        }
    }

    public void ShowNextImage()
    {
        if (galleryImages.Length == 0) return;
        currentIndex = (currentIndex + 1) % galleryImages.Length;
        displayImage.sprite = galleryImages[currentIndex];
    }

    public void ShowPreviousImage()
    {
        if (galleryImages.Length == 0) return;
        currentIndex = (currentIndex - 1 + galleryImages.Length) % galleryImages.Length;
        displayImage.sprite = galleryImages[currentIndex];
    }
}
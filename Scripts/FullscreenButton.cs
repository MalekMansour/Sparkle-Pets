using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullscreenButton : MonoBehaviour
{
    public Button fullscreenButton; 
    public TextMeshProUGUI buttonText; 

    void Start()
    {
        if (fullscreenButton != null && buttonText != null)
        {
            fullscreenButton.onClick.AddListener(ToggleFullscreen);
            UpdateButtonText(Screen.fullScreen);
        }
    }

    void ToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        UpdateButtonText(Screen.fullScreen);
    }

    void UpdateButtonText(bool isFullscreen)
    {
        if (isFullscreen)
        {
            buttonText.text = "Fullscreen OFF";
        }
        else
        {
            buttonText.text = "Fullscreen ON";
        }
    }
}

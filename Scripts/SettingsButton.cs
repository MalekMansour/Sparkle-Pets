using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public GameObject pauseMenu;    // Reference to the pause menu panel
    public GameObject settingsMenu; // Reference to the settings menu panel
    public Button settingsButton;   // Reference to the settings button

    void Start()
    {
        if (settingsButton != null)
        {
            settingsButton.onClick.AddListener(ToggleSettingsMenu);
        }
    }

    void ToggleSettingsMenu()
    {
        if (settingsMenu != null && pauseMenu != null)
        {
            bool isSettingsActive = settingsMenu.activeSelf;
            settingsMenu.SetActive(!isSettingsActive); // Toggle the settings menu
            pauseMenu.SetActive(isSettingsActive);     // Toggle the pause menu
        }
    }
}


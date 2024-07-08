using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject pauseMenu;    // Reference to the pause menu panel
    public GameObject settingsMenu; // Reference to the settings menu panel
    public Button backButton;       // Reference to the back button

    void Start()
    {
        if (backButton != null)
        {
            backButton.onClick.AddListener(BackToPauseMenu);
        }
    }

    void BackToPauseMenu()
    {
        if (pauseMenu != null && settingsMenu != null)
        {
            settingsMenu.SetActive(false); // Hide the settings menu
            pauseMenu.SetActive(true);     // Show the pause menu
        }
    }
}


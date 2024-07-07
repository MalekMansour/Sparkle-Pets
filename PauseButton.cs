using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public GameObject pauseMenu; // Reference to the pause menu panel
    public Button pauseButton;   // Reference to the pause button

    private bool isPaused = false; // Track the pause state

    void Start()
    {
        if (pauseButton != null)
        {
            pauseButton.onClick.AddListener(TogglePauseMenu);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        isPaused = !isPaused; // Toggle the pause state

        if (pauseMenu != null)
        {
            pauseMenu.SetActive(isPaused); // Show or hide the pause menu
        }

        if (isPaused)
        {
            Time.timeScale = 0f; // Pause the game
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
        }
    }
}


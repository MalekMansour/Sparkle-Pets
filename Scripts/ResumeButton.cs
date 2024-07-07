using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public GameObject pauseMenu; // Reference to the pause menu panel
    public Button resumeButton;  // Reference to the resume button

    void Start()
    {
        if (resumeButton != null)
        {
            resumeButton.onClick.AddListener(ResumeGame);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeSelf)
        {
            ResumeGame();
        }
    }

    void ResumeGame()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false); // Hide the pause menu
        }

        Time.timeScale = 1f; // Resume the game
    }
}


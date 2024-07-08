using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public GameObject pauseMenu;   
    public GameObject settingsMenu; 
    public Button pauseButton;      
    private bool isPaused = false;  

    void Start()
    {
        if (pauseButton != null)
        {
            pauseButton.onClick.AddListener(TogglePauseMenu);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !settingsMenu.activeSelf)
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        if (pauseMenu != null && !pauseMenu.activeSelf)
        {
            isPaused = true;
            pauseMenu.SetActive(true);
            Time.timeScale = 0f; 
        }
        else if (pauseMenu != null && pauseMenu.activeSelf)
        {
            isPaused = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1f; 
        }
    }
}

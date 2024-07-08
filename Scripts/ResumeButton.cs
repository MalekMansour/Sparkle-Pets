using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public GameObject pauseMenu; 
    public Button resumeButton; 

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
            pauseMenu.SetActive(false); 
        }

        Time.timeScale = 1f; 
    }
}

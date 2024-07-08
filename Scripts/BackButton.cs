using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject pauseMenu;    
    public GameObject settingsMenu; 
    public Button backButton;      

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
            settingsMenu.SetActive(false);
            pauseMenu.SetActive(true);     
        }
    }
}

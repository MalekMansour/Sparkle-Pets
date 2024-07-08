using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public GameObject pauseMenu;   
    public GameObject settingsMenu;
    public Button settingsButton;   
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
            settingsMenu.SetActive(!isSettingsActive); 
            pauseMenu.SetActive(isSettingsActive);    
        }
    }
}

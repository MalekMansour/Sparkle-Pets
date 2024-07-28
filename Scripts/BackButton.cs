using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject targetMenu; // The menu or page to go back to
    public GameObject currentMenu; // The current menu or page to deactivate
    public Button backButton;      // The back button

    void Start()
    {
        if (backButton != null)
        {
            backButton.onClick.AddListener(GoBackToTargetMenu);
        }
    }

    void GoBackToTargetMenu()
    {
        if (currentMenu != null && targetMenu != null)
        {
            currentMenu.SetActive(false);
            targetMenu.SetActive(true);     
        }
    }
}

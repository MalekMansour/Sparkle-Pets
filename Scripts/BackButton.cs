using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject targetMenu; 
    public GameObject currentMenu; 
    public Button backButton;      

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

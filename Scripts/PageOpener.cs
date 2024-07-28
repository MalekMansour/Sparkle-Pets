using UnityEngine;
using UnityEngine.UI;

public class PageOpener : MonoBehaviour
{
    public GameObject targetPage; 
    public Button openButton;    

    void Start()
    {
        if (openButton != null)
        {
            openButton.onClick.AddListener(OpenPage);
        }
    }

    void OpenPage()
    {
        if (targetPage != null)
        {
            targetPage.SetActive(true);
        }
    }
}

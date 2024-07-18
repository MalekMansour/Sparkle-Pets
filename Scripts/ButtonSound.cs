using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonSound;   

    void Start()
    {
        // Find all buttons in the scene
        Button[] buttons = FindObjectsOfType<Button>();

        // Add the PlaySound method to each button's onClick event
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(PlaySound);
        }
    }

    void PlaySound()
    {
        if (audioSource != null && buttonSound != null)
        {
            audioSource.PlayOneShot(buttonSound);
        }
    }
}


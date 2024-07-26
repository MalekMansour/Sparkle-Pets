using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource musicSource; // Reference to the AudioSource component playing the music
    public Slider volumeSlider;     // Reference to the UI slider

    void Start()
    {
        if (volumeSlider != null)
        {
            volumeSlider.onValueChanged.AddListener(AdjustVolume);
            volumeSlider.value = musicSource.volume; // Initialize slider value to the current volume
        }
    }

    void AdjustVolume(float volume)
    {
        if (musicSource != null)
        {
            musicSource.volume = volume;
        }
    }
}


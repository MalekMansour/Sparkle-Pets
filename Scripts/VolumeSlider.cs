using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource musicSource;     
    public Slider volumeSlider;         
    public TextMeshProUGUI volumeText;  

    void Start()
    {
        if (volumeSlider != null)
        {
            volumeSlider.minValue = 0;
            volumeSlider.maxValue = 1;
            volumeSlider.wholeNumbers = false;
            volumeSlider.value = 1f; 
            volumeSlider.onValueChanged.AddListener(AdjustVolume);
            UpdateVolumeText(volumeSlider.value); 
        }
    }

    void AdjustVolume(float volume)
    {
        if (musicSource != null)
        {
            musicSource.volume = volume;
            UpdateVolumeText(volume); 
        }
    }

    void UpdateVolumeText(float volume)
    {
        if (volumeText != null)
        {
            int volumePercentage = Mathf.RoundToInt(volume * 100);
            volumeText.text = volumePercentage + "%";
        }
    }
}

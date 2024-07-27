using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResolutionSlider : MonoBehaviour
{
    public Slider resolutionSlider;
    public TextMeshProUGUI resolutionText; 

    private readonly string[] resolutions = new string[]
    {
        "800x600",
        "1024x768",
        "1280x720",
        "1440x900",
        "1600x900",
        "1680x1050",
        "1920x1080",
        "1920x1200"
    };

    void Start()
    {
        if (resolutionSlider != null)
        {
            resolutionSlider.minValue = 1;
            resolutionSlider.maxValue = resolutions.Length;
            resolutionSlider.wholeNumbers = true;
            resolutionSlider.onValueChanged.AddListener(UpdateResolutionText);
            UpdateResolutionText(resolutionSlider.value); 
        }
    }

    void UpdateResolutionText(float value)
    {
        int index = Mathf.RoundToInt(value) - 1;
        if (resolutionText != null && index >= 0 && index < resolutions.Length)
        {
            resolutionText.text = resolutions[index];
        }
    }
}

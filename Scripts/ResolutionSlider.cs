using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResolutionSlider : MonoBehaviour
{
    public Slider resolutionSlider; // Reference to the slider
    public TextMeshProUGUI resolutionText; // Reference to the TextMeshPro text element

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
            resolutionSlider.value = resolutions.Length; // Set to highest value
            resolutionSlider.onValueChanged.AddListener(UpdateResolutionText);
            UpdateResolutionText(resolutionSlider.value); // Initialize the text
        }
    }

    void UpdateResolutionText(float value)
    {
        int index = Mathf.RoundToInt(value) - 1;
        if (resolutionText != null && index >= 0 && index < resolutions.Length)
        {
            resolutionText.text = resolutions[index];
            string[] res = resolutions[index].Split('x');
            int width = int.Parse(res[0]);
            int height = int.Parse(res[1]);
            Screen.SetResolution(width, height, Screen.fullScreen);
        }
    }
}

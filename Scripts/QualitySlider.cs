using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QualitySlider : MonoBehaviour
{
    public Slider qualitySlider; 
    public TextMeshProUGUI qualityText; // Reference to the TextMeshPro text element

    private readonly string[] qualityLevels = new string[]
    {
        "Very Low",
        "Low",
        "Medium",
        "High",
        "Very High",
        "Ultra"
    };

    void Start()
    {
        if (qualitySlider != null)
        {
            qualitySlider.minValue = 1;
            qualitySlider.maxValue = qualityLevels.Length;
            qualitySlider.wholeNumbers = true;
            qualitySlider.value = qualityLevels.Length; // Set to highest value
            qualitySlider.onValueChanged.AddListener(UpdateQualityText);
            UpdateQualityText(qualitySlider.value); // Initialize the text
        }
    }

    void UpdateQualityText(float value)
    {
        int index = Mathf.RoundToInt(value) - 1;
        if (qualityText != null && index >= 0 && index < qualityLevels.Length)
        {
            qualityText.text = qualityLevels[index];
            QualitySettings.SetQualityLevel(index);
        }
    }
}

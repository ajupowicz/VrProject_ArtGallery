using UnityEngine;
using TMPro; // Required for TextMeshPro text handling!

public class ExhibitInfo : MonoBehaviour
{
    [Header("Exhibit Information")]
    public string title = "Artwork Title";
    public string author = "Author / Artist";

    // The TextArea attribute makes the text box larger in the Unity Inspector
    [TextArea(3, 10)]
    public string description = "Enter the exhibit description here...";

    [Header("UI Plaque Connections")]
    [Tooltip("Drag TextMeshPro objects from your scene here")]
    public TMP_Text titleUIText;
    public TMP_Text authorUIText;
    public TMP_Text descriptionUIText;

    void Start()
    {
        // This function runs automatically when the game starts
        UpdatePlaque();
    }

    // Separate function to update texts (useful for potential future features
    // like changing the language during gameplay)
    public void UpdatePlaque()
    {
        if (titleUIText != null) titleUIText.text = title;
        if (authorUIText != null) authorUIText.text = author;
        if (descriptionUIText != null) descriptionUIText.text = description;
    }
}
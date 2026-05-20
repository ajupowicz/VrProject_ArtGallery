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
    public bool visible = true;
    public TMP_Text titleUIText;
    public TMP_Text authorUIText;
    public TMP_Text descriptionUIText;

    void Start()
    {
        // This function runs automatically when the game starts 
        UpdatePlaque(); // Initialize the plaque with the current exhibit information
    }

    // Separate function to update texts (useful for potential future features
    // like changing the language during gameplay)
    public void UpdatePlaque()
    {
        this.visible = !this.visible;
        if (this.visible == true){
            if (this.titleUIText != null) titleUIText.text = title;
            if (this.authorUIText != null) authorUIText.text = author;
            if (this.descriptionUIText != null) descriptionUIText.text = description;
        }
        else{        
        this.titleUIText.text = "";
        this.authorUIText.text = "";
        this.descriptionUIText.text = "";}
    }
}
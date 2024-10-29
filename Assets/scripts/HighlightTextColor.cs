using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class HighlightTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI buttonText; // Assign your TextMeshPro component here
    public Color highlightColor = Color.yellow;
    private Color originalColor;

    void Start()
    {
        if (buttonText != null)
            originalColor = buttonText.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (buttonText != null)
            buttonText.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (buttonText != null)
            buttonText.color = originalColor;
    }
}

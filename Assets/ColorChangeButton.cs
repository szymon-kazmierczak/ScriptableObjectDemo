using UnityEngine;
using UnityEngine.UI;


public class ColorChangeButton : MonoBehaviour
{
    public Theme theme;

    private Image _buttonImage;
    private Text _textComponent;

    private void Start()
    {
        // Cache references
        _textComponent = GetComponentInChildren<Text>();
        _buttonImage = gameObject.GetComponent<Image>();

        // Set Initial Values
        UpdateValues();

        // Subscribe to event in case the values are changed and update them
        theme.OnColorChanged += UpdateValues;
    }

    private void UpdateValues()
    {
        _buttonImage.color = theme.ButtonColor;
        _textComponent.text = $"Click me to change my colour! My colour is {theme.ButtonColor}";
    }

    public void ChangeBackgroundColor()
    {
        theme.ChangeButtonColor(Random.ColorHSV());
    }
}

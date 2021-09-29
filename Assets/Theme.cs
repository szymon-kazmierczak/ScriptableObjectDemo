using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Create Theme", fileName = "Theme")]
public class Theme : ScriptableObject
{
    public event Action OnColorChanged;

    public Color ButtonColor
    {
        get => _buttonColor;
        private set
        {
            _buttonColor = value;
            OnColorChanged?.Invoke();;
        }
    }

    private Color _buttonColor;

    // Either this, expose setter or another solution like being able to set whole theme in one go? Multiple colors at once? up to you

    // Could have overloads for different types of color setting, like the html parser we have in your branch?
    public void ChangeButtonColor(Color color)
    {
        ButtonColor = color;
    }
}

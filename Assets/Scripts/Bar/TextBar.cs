using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textBar;

    private float _maxValue = 1;

    public void SetMaxValue(float value)
    {
        _maxValue = value;
    }

    public void SetStartingValue()
    {
        SetValues(_maxValue);
    }

    public void SetValues(float value)
    {
        _textBar.text = $"Здоровье игрока: {value} / {_maxValue}";
    }
}

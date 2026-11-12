using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textBar;
    [SerializeField] private Health _health;

    private void Start()
    {
        ChangeValue(_health.MaxValue, _health.MaxValue);
    }

    private void OnEnable()
    {
        _health.ValueChanged += ChangeValue;        
    }

    private void OnDisable()
    {
        _health.ValueChanged -= ChangeValue;
    }

    private void ChangeValue(float value, float MaxValue)
    {
        _textBar.text = $"Здоровье игрока: {value} / {MaxValue}";
    }
}

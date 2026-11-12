using UnityEngine;

public class HealthRenderer : MonoBehaviour
{
    [SerializeField] private TextBar _textBar;
    [SerializeField] private InstantBar _instantBar;
    [SerializeField] private SmoothBar _smoothBar;

    public void SetMaxValue(int value)
    {
        _textBar.SetMaxValue(value);
        _instantBar.SetMaxValue(value);
        _smoothBar.SetMaxValue(value);
    }

    public void SetStartingValue()
    {
        _textBar.SetStartingValue();
        _instantBar.SetStartingValue();
        _smoothBar.SetStartingValue();
    }

    public void ChangeValue(float value)
    {
        _textBar.SetValues(value);
        _instantBar.ChangeValue(value);
        _smoothBar.ChangeValue(value);
    }
}
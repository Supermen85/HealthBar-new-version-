using UnityEngine;

public class Bar<T> : MonoBehaviour where T : BarRenderer
{
    private T _barRender;

    private float _maxValue = 1;

    private void Awake()
    {
        _barRender = GetComponent<T>();
    }

    public void SetMaxValue(float value)
    {
        _maxValue = value;
    }

    public void SetStartingValue()
    {
        _barRender.SetStartingValue(_maxValue);
    }

    public void ChangeValue(float value)
    {
        _barRender.ChangeValue(value, _maxValue);
    }
 }

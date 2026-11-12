using System;
using UnityEngine;

[RequireComponent(typeof(HealthRenderer))]

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxValue = 100;

    public event Action Died;

    private HealthRenderer _healthRenderer;

    private int _currentValue;

    private void Awake()
    {
        _healthRenderer = GetComponent<HealthRenderer>();
    }

    private void Start()
    {
        _currentValue = _maxValue;
        _healthRenderer.SetMaxValue(_maxValue);
        _healthRenderer.SetStartingValue();
    }

    public void Heal(int healPower)
    {
        _currentValue = Mathf.Min(_maxValue, _currentValue + healPower);

        _healthRenderer.ChangeValue(_currentValue);
    }

    public void TakeDamge(int damage)
    {
        _currentValue = Mathf.Max(0, _currentValue - damage);

        _healthRenderer.ChangeValue(_currentValue);

        if (IsDead())
            Died?.Invoke();
    }

    private bool IsDead()
    {
        return _currentValue <= 0;
    }
}

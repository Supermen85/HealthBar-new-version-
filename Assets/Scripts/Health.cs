using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [field: SerializeField] public int MaxValue { get; private set; } = 100;

    public event Action Died;
    public event Action<float, float> ValueChanged;

    private int _currentValue;

    private void Start()
    {
        _currentValue = MaxValue;
    }

    public void Heal(int healPower)
    {
        _currentValue = Mathf.Min(MaxValue, _currentValue + healPower);
        
        ValueChanged?.Invoke(_currentValue, MaxValue);
    }

    public void TakeDamge(int damage)
    {
        _currentValue = Mathf.Max(0, _currentValue - damage);
        
        ValueChanged?.Invoke(_currentValue, MaxValue);

        if (IsDead())
            Died?.Invoke();
    }

    private bool IsDead()
    {
        return _currentValue <= 0;
    }
}

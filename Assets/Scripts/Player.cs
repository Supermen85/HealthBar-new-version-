using UnityEngine;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(DistanceChecker))]
[RequireComponent(typeof(Health))]

public class Player : MonoBehaviour
{
    private Mover _mover;
    private DistanceChecker _distanceChecker;
    private Health _health;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
        _distanceChecker = GetComponent<DistanceChecker>();
        _health = GetComponent<Health>();
    }

    private void OnEnable()
    {
        _health.Died += Die;
    }

    private void OnDisable()
    {
        _health.Died -= Die;
    }

    private void FixedUpdate()
    {
        if (_distanceChecker.IsCloseEnough(_mover.CurrentCheckpoint.position))
            _mover.SwitchCheckpoint();

        _mover.Move();
    }

    public void TakeDamage(int damage)
    {
        _health.TakeDamge(damage);
    }

    public void Heal(int healPower)
    {
        _health.Heal(healPower);
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}

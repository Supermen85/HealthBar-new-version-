using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _checkpoint1;
    [SerializeField] private Transform _checkpoint2;

    [SerializeField] private float _speed = 1f;
    
    public Transform CurrentCheckpoint { get; private set; }

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        CurrentCheckpoint = _checkpoint1;
    }

    public void Move()
    {
        Vector2 direction = (CurrentCheckpoint.position - transform.position).normalized;
        _rigidbody2D.velocity = new Vector2(direction.x * _speed, 0);
    }

    public void SwitchCheckpoint()
    {
        CurrentCheckpoint = CurrentCheckpoint == _checkpoint1 ? _checkpoint2 : _checkpoint1;
    }
}

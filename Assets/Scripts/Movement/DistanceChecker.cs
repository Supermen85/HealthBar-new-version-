using UnityEngine;

public class DistanceChecker : MonoBehaviour
{
    [SerializeField] float _minDistance = 0.2f;

    public bool IsCloseEnough(Vector2 position)
    {
        return (position - (Vector2)transform.position).sqrMagnitude < _minDistance * _minDistance;
    }
}

using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _movementRange = 2f;

    private float _startPositionX;
    private float _direction = 1f;

    private void Awake()
    {
        _startPositionX = transform.position.x;
    }

    private void FixedUpdate()
    {
        // Move the platform horizontally
        Vector2 position = transform.position;
        position.x += _speed * _direction * Time.fixedDeltaTime;
        transform.position = position;

        // Reverse direction if platform reaches movement range
        if (Mathf.Abs(transform.position.x - _startPositionX) >= _movementRange)
        {
            _direction *= -1f;
        }
    }
}

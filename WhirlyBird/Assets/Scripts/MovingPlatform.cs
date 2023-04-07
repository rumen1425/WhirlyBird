using UnityEngine;

public class MovingPlatform : Platform
{
    private DestructionHandler _destructionHandler;

    private PlatformMovement _movementComponent;

    private void Awake()
    {
        _destructionHandler = GetComponent<DestructionHandler>();
        _movementComponent = GetComponent<PlatformMovement>();
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);

        // Handle destruction if necessary
        if (_destructionHandler != null)
        {
            _destructionHandler.OnCollisionEnter2D(collision);
        }
    }
}

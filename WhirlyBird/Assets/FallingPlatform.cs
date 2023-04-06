using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : Platform
{
    [SerializeField] private float fallDelay = 1.5f;
    private int numCollisions = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && numCollisions == 0)
        {
            numCollisions++;
            Invoke("Fall", fallDelay);
        }
        else if (numCollisions == 1)
        {
            Destroy(gameObject);
        }
    }

    private void Fall()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}

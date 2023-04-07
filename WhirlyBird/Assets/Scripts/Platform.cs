using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] private float jumpForce = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            
            if (rb!= null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                velocity.x = rb.velocity.x;
                rb.velocity = velocity;
            }
        }

    }
    

}


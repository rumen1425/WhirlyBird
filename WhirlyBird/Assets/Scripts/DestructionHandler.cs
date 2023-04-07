using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionHandler : MonoBehaviour
{
    private int numCollisions = 0;
    [SerializeField] private int _allowedCollisions = 3;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && numCollisions == 0)
        {
            numCollisions++;
        }
        else if (numCollisions > 0 && numCollisions < _allowedCollisions)
        {
            numCollisions++;
        }
        else if (numCollisions == _allowedCollisions)
        {
            Destroy(gameObject);
        }
    }
}
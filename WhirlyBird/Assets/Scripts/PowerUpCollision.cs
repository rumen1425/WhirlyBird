using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollision : MonoBehaviour
{
    public PowerUp powerUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        powerUp.ApplyToPlayer(collision.gameObject);
    }
}


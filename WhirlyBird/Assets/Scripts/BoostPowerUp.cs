using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Powerups/BoostPowerUp")]

public class BoostPowerUp : PowerUp
{

    public float BoostAmount;

    public override void ApplyToPlayer(GameObject receiver)
    {

        Rigidbody2D rb = receiver.GetComponent<Rigidbody2D>();

        if (rb != null )
        {
            rb.velocity = new Vector2(rb.velocity.x, BoostAmount);

        }
    }
}

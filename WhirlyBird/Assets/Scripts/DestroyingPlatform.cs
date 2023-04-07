using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingPlatform : Platform
{
    private DestructionHandler destructionHandler;

    private void Awake()
    {
        destructionHandler = GetComponent<DestructionHandler>();
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        destructionHandler.OnCollisionEnter2D(collision);
    }
}
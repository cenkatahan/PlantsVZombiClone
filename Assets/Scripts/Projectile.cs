using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private new Rigidbody2D rigidbody2D;

    private void Update()
    {
        rigidbody2D.linearVelocity = transform.right * speed;
        
    }
}

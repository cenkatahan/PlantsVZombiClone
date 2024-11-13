using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 5f;

    void Update()
    {
        rigidbody2D.linearVelocity = new Vector2(-moveSpeed, rigidbody2D.linearVelocity.y);
    }
    
}
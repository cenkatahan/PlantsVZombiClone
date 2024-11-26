using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 5f;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, -90f);
    }

    void Update()
    {
        rigidbody2D.linearVelocity = new Vector2(-moveSpeed, rigidbody2D.linearVelocity.y);
    }
}
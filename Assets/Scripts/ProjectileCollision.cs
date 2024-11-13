using System;
using UnityEngine;
using UnityEngine.Events;

public class ProjectileCollision : MonoBehaviour
{
    // [SerializeField] private UnityEvent OnEnemyHitemyHit;

    public delegate void OnHit();

    public static event OnHit OnHitEnemy;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Enemy")) return;
        OnHitEnemy?.Invoke();
        Destroy(other.gameObject);
    }
}

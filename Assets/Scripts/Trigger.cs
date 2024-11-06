using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Trigger : MonoBehaviour
{

    [SerializeField] private OnEnemyDetected onEnemyDetected;
    private void OnTriggerStay2D(Collider2D other)
    {
        // onEnemyDetected.Invoke();
    }

    private void Start()
    {
        onEnemyDetected.Invoke();
    }
}

[Serializable]
public class OnEnemyDetected : UnityEvent
{
}
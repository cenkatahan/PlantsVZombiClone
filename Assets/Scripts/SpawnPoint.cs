using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, 1.8f);
    }

    private void Spawn()
    {
        Instantiate(enemyPrefab, gameObject.transform.position, Quaternion.identity);
    }
    
}

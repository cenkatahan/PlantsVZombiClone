using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void OnEnable()
    {
        WaveManager.OnWaveComplete += StopSpawning;
        WaveManager.OnWaveStart += Spawn;
    }

    private void OnDisable()
    {
        WaveManager.OnWaveComplete -= StopSpawning;
        WaveManager.OnWaveStart -= Spawn;
    }

    private void Start()
    {
        // InvokeRepeating(nameof(Spawn), 1f, 1.8f);
    }

    private void Spawn()
    {
        InvokeRepeating(nameof(CreateEnemy), 1f, 1.8f);
    }
    
    private void CreateEnemy()
    {
        Instantiate(enemyPrefab, gameObject.transform.position, Quaternion.identity);
    }

    private void StopSpawning()
    {
        // CancelInvoke(nameof(Spawn));
        StopAllCoroutines();
    }
    
}

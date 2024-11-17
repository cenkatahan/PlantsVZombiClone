using System;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private Wave currentWave;

    private int _currentEnemyCount;


    // onWaveComplete
    public delegate void OnWaveEnded();
    public static event OnWaveEnded OnWaveComplete;
    
    //onWaveStart
    public delegate void OnWaveStarted();
    public static event OnWaveStarted OnWaveStart;

    private void Start()
    {
        OnWaveStart?.Invoke();
    }


    private void Update()
    {
        if (_currentEnemyCount >= currentWave.size)
        {
            OnWaveComplete?.Invoke();
        }
    }
}
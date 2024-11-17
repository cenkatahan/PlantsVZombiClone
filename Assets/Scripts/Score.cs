using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    
    private int _score;

    private void OnEnable()
    {
        ProjectileCollision.OnHitEnemy += UpdateScore;
    }

    private void OnDisable()
    {
        ProjectileCollision.OnHitEnemy -= UpdateScore;
    }


    private void Update()
    {
        Debug.Log("Score: " + _score);
    }


    private void UpdateScore()
    {
        _score++;
    }
    
    
}

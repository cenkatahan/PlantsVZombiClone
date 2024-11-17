using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private float timer = 5f;

    // private void Start()
    // {
    //     StartCoroutine(Shoot());
    // }

    private void OnEnable()
    {
        WaveManager.OnWaveComplete += StopTurret;
    }

    private void OnDisable()
    {
        WaveManager.OnWaveComplete -= StopTurret;
    }

    public void Fire()
    {
        // StartCoroutine(Shoot());
        Shoot();
    }

    private void Shoot()
    {
        Instantiate(projectilePrefab, spawnPosition.position, projectilePrefab.transform.rotation);
    }

    // ReSharper disable once FunctionRecursiveOnAllPaths
    private IEnumerator Shooxt()
    {
        // yield return new WaitForSeconds(2f);
        var projectile = Instantiate(projectilePrefab, spawnPosition.position, projectilePrefab.transform.rotation);
        // StartCoroutine(Shoot());
        yield return new WaitForSeconds(2f);
        Destroy(projectile);
    }

    private void StopTurret()
    {
        StopAllCoroutines();
    }
}
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

    public void Fire()
    {
        StartCoroutine(Shoot());
    }

    // ReSharper disable once FunctionRecursiveOnAllPaths
    public IEnumerator Shoot()
    {
        yield return new WaitForSeconds(2f);
        var projectile = Instantiate(projectilePrefab, spawnPosition.position, projectilePrefab.transform.rotation);
        StartCoroutine(Shoot());
        yield return new WaitForSeconds(4f);
        Destroy(projectile);
    }
}


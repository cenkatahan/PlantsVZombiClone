using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform spawnPosition;

    [SerializeField] private float fireRate = .5f;
    private float _nextFire;

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
        if (!(Time.time >= _nextFire)) return;
        _nextFire = Time.time + fireRate;
        Shoot();
    }

    private void Shoot()
    {
        Instantiate(projectilePrefab, spawnPosition.position, projectilePrefab.transform.rotation);
    }

    private void StopTurret()
    {
        StopAllCoroutines();
    }
}
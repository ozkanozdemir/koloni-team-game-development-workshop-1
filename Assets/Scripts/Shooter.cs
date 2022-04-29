using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Shooter : MonoBehaviour
{
    [Header("General")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float projectileSpeed = 10f;
    [SerializeField] private float projectileLifeTime = 5f;
    [SerializeField] private float baseFiringRate = 0.2f;
    [SerializeField] private float range = 15f;
    [SerializeField] private float turnSpeed = 10f;
    
    [Header("AI")]
    [SerializeField] private bool useAI;
    [SerializeField] private float firingRateVariance = 0f;
    [SerializeField] private float minimumFiringRate = 0.1f;

    [HideInInspector] public bool isFiring;

    private Coroutine _firingCoroutine;
    private Transform _target;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(UpdateTarget());
    }

    // Update is called once per frame
    private void Update()
    {
        Fire();
    }

    private void Fire()
    {
        if (_target && _firingCoroutine == null)
        {
            _firingCoroutine = StartCoroutine(FireContinuously());
        }
        else if (!_target && _firingCoroutine != null)
        {
            StopCoroutine(_firingCoroutine);
            _firingCoroutine = null;
        }
    }

    private IEnumerator UpdateTarget()
    {
        while (true)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            // float shortestDistance = Mathf.Infinity;
            // GameObject nearestEnemy = null;

            // foreach(GameObject enemy in enemies)
            // {
            //     Debug.Log("transform.position : " + transform.position);
            //     Debug.Log("enemy.transform.position : " + enemy.transform.position);
            //     float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            //     Debug.Log("distanceToEnemy : " + distanceToEnemy);
            //     Debug.Log("shortestDistance : " + shortestDistance);
            //     if(distanceToEnemy < shortestDistance)
            //     {
            //         shortestDistance = distanceToEnemy;
            //         nearestEnemy = enemy;
            //
            //     }
            // }
            
            // Debug.Log("range : " + range);
            // Debug.Log("shortestDistance : " + shortestDistance);

            // if (nearestEnemy != null && shortestDistance <= range)
            // {
            //     Debug.Log("nearestEnemy.name : " + nearestEnemy.name);
            //     _target = nearestEnemy.transform;
            // }
            
            if (enemies.Length > 0)
            {
                _target = enemies[0].transform;
                
                if (_firingCoroutine == null)
                {
                    _firingCoroutine = StartCoroutine(FireContinuously());
                }
            }
            else
            {
                _target = null;

                if (_firingCoroutine != null)
                {
                    StopCoroutine(_firingCoroutine);
                    _firingCoroutine = null;
                }
            }

            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator FireContinuously()
    {
        if (_target)
        {
            Debug.Log("Hedefin adı : " + _target.name);
        }
        
        while (_target)
        {
            Debug.Log("Ateş ediliyor...");
            
            // HEDEFE KILITLENME (TARGET LOCK ON)
            Vector3 dir = _target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation,Time.deltaTime * turnSpeed).eulerAngles;
            transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
            
            var instance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            var rb = instance.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = transform.forward * projectileSpeed;
            }

            Destroy(instance, projectileLifeTime);

            var timeToNextProjectile =
                Random.Range(baseFiringRate - firingRateVariance, baseFiringRate + firingRateVariance);
            timeToNextProjectile = Mathf.Clamp(timeToNextProjectile, minimumFiringRate, float.MaxValue);

            yield return new WaitForSeconds(timeToNextProjectile);
        }
    }
}

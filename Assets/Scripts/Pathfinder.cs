using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 2f;
    
    private WaveConfigSO _waveConfig;
    private List<Transform> _waypoints;
    private int _waypointIndex = 0;
    private EnemySpawner _enemySpawner;

    private void Awake()
    {
        _enemySpawner = FindObjectOfType<EnemySpawner>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        _waveConfig = _enemySpawner.GetCurrentWave();
        _waypoints = _waveConfig.GetWaypoints();
        transform.position = _waypoints[_waypointIndex].position; 
        
        SetRotation(0f);
    }

    // Update is called once per frame
    private void Update()
    {
        FollowPath();
    }

    private void FollowPath()
    {
        if (_waypointIndex < _waypoints.Count)
        {
            // Sonraki hedefe doğru ilerleme
            Vector3 targetPosition = _waypoints[_waypointIndex].position;
            var delta = _waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, delta);
            
           SetRotation(rotateSpeed);

            if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
            {
                _waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Sonraki hedefe doğru dönme
    private void SetRotation(float speed)
    {
        Vector3 targetDirection = _waypoints[_waypointIndex].position - transform.position;
        Vector3 newDirection =
            Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
        Debug.DrawRay(transform.position, newDirection, Color.red);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
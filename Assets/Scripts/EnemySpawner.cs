using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<WaveConfigSO> waveConfigs;
    [SerializeField] private float timeBetweenWaves = 0f;
    [SerializeField] private bool isLooping;
    private UIatechment _uIatechment;

    private WaveConfigSO _currentWave;
 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyWaves());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public WaveConfigSO GetCurrentWave()
    {   
        return _currentWave;

    }

    private IEnumerator SpawnEnemyWaves()
    {
        _uIatechment=FindObjectOfType<UIatechment>();
        _uIatechment.GetWaveIncreases();
        //Wawe ba�lamas�
        do
        {
            foreach (var waveConfig in waveConfigs)
            {
                for (int i = 0; i < waveConfig.GetEnemyCount(); i++)
                {
                    _currentWave = waveConfig;
                    
                    Instantiate(waveConfig.GetEnemyPrefab(i), 
                        waveConfig.GetStartingWaypoint().position, 
                        Quaternion.identity, 
                        transform);

                    yield return new WaitForSeconds(waveConfig.GetRandomSpawnTime());
                }   
            
                yield return new WaitForSeconds(timeBetweenWaves);
            }
        } 
        while (isLooping);
    }

    
}
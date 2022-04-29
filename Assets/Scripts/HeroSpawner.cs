using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HeroSpawn(int Hero)
    {
        Instantiate(gameObjects[Hero], new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("sda");
    }
    
}

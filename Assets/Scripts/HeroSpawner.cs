using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawner : MonoBehaviour
{
     public GameObject[] gameObjects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HeroSpawn(int Hero)
    {   
        if(gameObject == null)
        {
            Debug.Log("NullReferens");
        }
        Instantiate(gameObjects[Hero], new Vector3(0, 0, 0), Quaternion.identity);
        
    }
    
}

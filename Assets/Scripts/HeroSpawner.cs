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
        int i=0;
        if (gameObject == null)
        {
            Debug.Log("NullReferens");
        }
        while (true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                i++;
                Debug.Log(i);
                if (i==10)
                {
                    return;
                }
            }
        }

        
        
            //while (true)
            //{
            //    int der = Hero;
            //    Instantiate(gameObjects[Hero], new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z), Quaternion.identity);
            //}
        
        
        
        
            
        


        
        
        
    }
    
}

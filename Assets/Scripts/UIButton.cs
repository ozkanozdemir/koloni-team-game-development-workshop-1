using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIButton : MonoBehaviour
{
    // Start is called before the first frame update
    HeroSpawner heroSpawner;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ZenButton()
    {   
        heroSpawner=FindObjectOfType<HeroSpawner>();
        if (heroSpawner==null)
        {
            Debug.Log("hero Spawner are getting error");
        }
        heroSpawner.HeroSpawn(0);
        
        
    }
    public void ButtonDown()
    {
        Debug.Log("-");
    }
}

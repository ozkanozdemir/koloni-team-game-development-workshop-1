using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        heroSpawner.HeroSpawn(0);
        
        
    }
    public void ButtonDown()
    {
        Debug.Log("-");
    }
}

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
        heroSpawner.HeroSpawn(0);
        Debug.Log("sdasgagsa");
        
    }
    public void ButtonDown()
    {
        Debug.Log("-");
    }
}

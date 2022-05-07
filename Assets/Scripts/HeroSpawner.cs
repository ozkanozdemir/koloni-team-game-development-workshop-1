using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeroSpawner : MonoBehaviour
{
    



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public void HeroSpawn()
    {

        string clickWhich = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(clickWhich);
        
    }
    
}

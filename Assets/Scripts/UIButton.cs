using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIButton : MonoBehaviour
{
    // Start is called before the first frame update
    HeroSpawner heroSpawner;
    public Camera cam;
    void Start()
    {
        heroSpawner = GetComponent<HeroSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HeroButton()
    {
        
        Vector3 mousePos = Input.mousePosition;

        RaycastHit ray;

        //if (Physics.Raycast()
        //{

        //}
        
    }
    
}

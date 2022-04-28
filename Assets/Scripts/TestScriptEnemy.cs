using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptEnemy : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, 2f * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Config : MonoBehaviour
{   
    
    private float coin;
    private float wave;
    private float exp;
    private float level;


    public void GetIncreaseCoin()
    {
        coin++;
    }
    public void GetDecreaseCoin()
    {
        coin--;
    }
    public void GetIncreaseWawe()
    {
        wave++;
    }
    public void GetIncreaseExp()
    {
        exp++;
    }
    public void GetIncreaseLevel()
    {
        level++;
    }



}

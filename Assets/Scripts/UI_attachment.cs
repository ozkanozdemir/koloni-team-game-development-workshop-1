using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_atechment : MonoBehaviour
{
    public int Wave=0;
    public int WaveCount=5;
    public float Level;
    public float Coin;
    public float Exp;
    //public float Upgrade;
    //public float Sell;
    //public Button _Upgrade;
    //public Button _Sell;
    public Button _CharacterZen;
    public Button _CharacterKava;
    public Button _CharacterCecom;
    public Button _CharacterNazyanno;
    public Button _TimeDelay;
    public Button _Chaos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetWaveIncreases()
    {
        Wave++;
    }

    public void GetLevelIncreases()
    {
        Level++;
    }
    public void GetCoinIncreases(float value)
    {
        Coin += value;//This is Exmample value
    }
    public void GetCoinDecreases(float value)
    {
        Coin -= value;//This is Exmample value
    }
    public void GetExpIncreases(float value)
    {
        Exp += value;//This is Exmample value
    }

    //public void GetUpgradeIncreases()
    //{
    //    Coin += 5;//This is Exmample value
    //}
    //public void GetUpgradeDecreases()
    //{
    //    Coin -= 5;//This is Exmample value
    //}
    //public void GetSellIncreases()
    //{
    //    Coin += 5;//This is Exmample value
    //}
    //public void GetSellDecreases()
    //{
    //    Coin += 5;//This is Exmample value
    //}

}

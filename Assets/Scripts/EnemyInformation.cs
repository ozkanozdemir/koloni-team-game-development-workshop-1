using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerİnformation : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class EnemyDorkonit : Playerİnformation
{
    private float healt = 150f;
    private float speed = 6f;
    private float defanse = 5f;
    private float coinCost = 300f;
    private float expAmount = 50f;

    public float GetEnemyDorkonitHealt()
    {
        return healt;
    }
    public float GetEnemyDorkonitSpeed()
    {
        return speed;
    }
    public float GetEnemyDorkonitDefans()
    {
        return defanse;
    }
    public float GetEnemyDorkonitCoinCost()
    {
        return coinCost;
    }
    public float GetEnemyDorkonitExpAmount()
    {
        return expAmount;
    }

}
public class EnemySerikan : Playerİnformation
{
    private float healt = 80f;
    private float speed = 3f;
    private float defanse = 20f;
    private float coinCost = 300f;
    private float expAmount = 50f;

    public float GetEnemySerikanHealt()
    {
        return healt;
    }
    public float GetEnemySerikanSpeed()
    {
        return speed;
    }
    public float GetEnemySerikanDefans()
    {
        return defanse;
    }
    public float GetEnemySerikanCoinCost()
    {
        return coinCost;
    }
    public float GetEnemySerikanExpAmount()
    {
        return expAmount;
    }

}
public class EnemyJesova : Playerİnformation
{
    private float healt = 120f;
    private float speed = 10f;
    private float defanse = 2f;
    private float coinCost = 300f;
    private float expAmount = 50f;

    public float GetEnemyJesovaHealt()
    {
        return healt;
    }
    public float GetEnemyJesovaSpeed()
    {
        return speed;
    }
    
    public float GetEnemyJesovaDefans()
    {
        return defanse;
    }
    public float GetEnemyJesovaCoinCost()
    {
        return coinCost;
    }
    public float GetEnemyJesovaExpAmount()
    {
        return expAmount;
    }

}
public class EnemyYinelgi : Playerİnformation
{
    private float healt = 90f;
    private float speed = 1f;
    private float defanse = 2f;
    private float coinCost = 300f;
    private float expAmount = 50f;

    public float GetEnemyYinelgiHealt()
    {
        return healt;
    }
    public float GetEnemyYinelgiSpeed()
    {
        return speed;
    }
    
    public float GetEnemyYinelgiDefans()
    {
        return defanse;
    }
    public float GetEnemyYinelgiCoinCost()
    {
        return coinCost;
    }
    public float GetEnemyYinelgiExpAmount()
    {
        return expAmount;
    }

}

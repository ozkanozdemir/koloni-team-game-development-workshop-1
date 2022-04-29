using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInformation : MonoBehaviour
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
public class HeroZen : HeroInformation
{
    
    private float movementSpeed = 2f;//TODO: Exp eþik deðeri geçtiðinde güçler artcak
    private float atackDamage = 5f;
    private float coinCost = 50f;
    private float expPowerUpCost = 200f;

    
    public float GetHeroZenMovementSpeed()
    {
        return movementSpeed;
    }
    public float GetHeroZenAtackDamage()
    {
        return atackDamage;
    }

    public float GetHeroZenCoinCost()
    {
        return coinCost;
    }
    public float GetHeroZenExpAmount()
    {
        return expPowerUpCost;
    }

}
public class HeroKava : HeroInformation
{
    private float movementSpeed = 10f;//TODO: Exp eþik deðeri geçtiðinde güçler artcak
    private float atackDamage = 5f;
    private float coinCost = 250f;
    private float expPowerUpCost = 500f;
    
    public float GetHeroKavaMovementSpeed()
    {
        return movementSpeed;
    }
    public float GetHeroKavaAtackDamage()
    {
        return atackDamage;
    }

    public float GetHeroKavaCoinCost()
    {
        return coinCost;
    }
    public float GetHeroKavaExpPowerUpCost()
    {
        return expPowerUpCost;
    }

}
public class HeroCecom : HeroInformation
{
    private float movementSpeed = 15f;
    private float atackDamage = 4f;//TODO: Exp eþik deðeri geçtiðinde güçler artcak
    private float coinCost = 300f;
    private float expPowerUpCost = 600f;

    public float GetHeroCecomMovementSpeed()
    {
        return movementSpeed;
    }
    public float GetHeroCecomAtackDamage()
    {
        return atackDamage;
    }

    public float GetHeroCecomCoinCost()
    {
        return coinCost;
    }
    public float GetHeroCecomExpPowerUpCost()
    {
        return expPowerUpCost;
    }

}
public class HeroNazyanno : HeroInformation
{
    private float movementSpeed = 8f;//TODO: Exp eþik deðeri geçtiðinde güçler artcak
    private float atackDamage = 15f;
    private float coinCost = 500f;
    private float expPowerUpCost = 1500f;

    public float GetHeroNazyannoMovementSpeed()
    {
        return movementSpeed;
    }
    public float GetHeroNazyannoAtackDamage()
    {
        return atackDamage;
    }

    public float GetHeroNazyannoCoinCost()
    {
        return coinCost;
    }
    public float GetHeroNazyannoPowerUpCost()
    {
        return expPowerUpCost;
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int maxHealth = 100;
    UIatechment uIatechment;

    private Slider _slider;
    private bool _isAlive = true;

    private void Start()
    {
        _slider = GetComponentInChildren<Slider>();
        _slider.maxValue = maxHealth;
        _slider.value = health;
        
        // StartCoroutine(FakeDamage());
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        DamageDealer damageDealer = col.GetComponent<DamageDealer>();
        
        Debug.Log(col.name);
        
        if (damageDealer != null)
        {
            TakeDamage(damageDealer.GetDamage());
            damageDealer.Hit();
        }
    }
 
    private void TakeDamage(int value)
    {
        health -= value;
        _slider.value = health;

        Debug.Log("health : " + health);
        
        if (health <= 0)
        {
<<<<<<< Updated upstream
            // TODO: Ana kontroller'da altın sayısını arttır
            
=======
            uIatechment.GetExpIncreases();
            uIatechment.GetCoinIncreases();
            //d��man�n cinsine g�re para kazanma
>>>>>>> Stashed changes
            _isAlive = false;
            Destroy(gameObject);
        }
    }

    private IEnumerator FakeDamage()
    {
        while (_isAlive)
        {
            TakeDamage(10);

            yield return new WaitForSeconds(1f);
        }
    }
}
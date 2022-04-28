using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int maxHealth = 100;

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
            _isAlive = false;
            Destroy(gameObject);
        }
    }

    private IEnumerator FakeDamage()
    {
        while (_isAlive)
        {
            TakeDamage(7);

            yield return new WaitForSeconds(1f);
        }
    }
}
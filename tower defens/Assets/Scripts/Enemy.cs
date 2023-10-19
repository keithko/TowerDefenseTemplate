using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public float HP = 100;
    public float CurrentHP;
    public float Damage = -20;
    public static event Action Ondied;

    private void Start()
    {
        CurrentHP = HP;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            CurrentHP -= Damage;
            return;
        }
    }
    public void Die()
    {
        if(HP<= 0)
        {
            Ondied?.Invoke();
            Destroy(gameObject);
        }
        
    }

}

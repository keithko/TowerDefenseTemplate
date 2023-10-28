using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    private int HP = 10;
    private int startHP;
    public int CurrentHP;
    public int Damage = 2;
    public static event Action<int> Ondied;

    private void Start()
    {
        CurrentHP = HP;
        startHP = HP;
    }
    private void Update()
    {
        Die();
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
        if(CurrentHP<= 0)
        {
            Ondied?.Invoke(startHP);
            Destroy(gameObject);
        }
        
    }

}

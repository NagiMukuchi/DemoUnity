﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 20;
    public int damage;

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
        

        var boss = collision.GetComponent<BossHealth>();
        if (boss != null)
        {
            boss.TakeDamage(damage);
        }
        Destroy(gameObject);
        

    }



}



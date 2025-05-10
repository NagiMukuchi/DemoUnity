using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHits = 20;       // Số lần trúng đạn để chết
    private int currentHits = 0;   // Số lần đã trúng đạn

    public void TakeDamage(int damage)
    {
        currentHits++;
        Debug.Log($"Boss hit {currentHits}/{maxHits}");

        if (currentHits >= maxHits)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Boss died!");
        Destroy(gameObject);
    }
}

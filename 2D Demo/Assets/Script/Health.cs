using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    public System.Action onDead;
    public System.Action onHealthChanged;
    public int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint;
        onHealthChanged?.Invoke();

    }

    public void TakeDamage(int damage)
    {
        healthPoint -= damage;
        if (healthPoint <= 0) { Die(); 
        }
        else
        {
            var hit = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(hit, 1);
        }
        {
            if (healthPoint <= 0) return;

            healthPoint -= damage;
            onHealthChanged?.Invoke();
            if (healthPoint <= 0) Die();
        }

    }



    public void OnTriggerEnter2D(Collider2D collision) => TakeDamage(1);

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
        onDead?.Invoke();
    }


}

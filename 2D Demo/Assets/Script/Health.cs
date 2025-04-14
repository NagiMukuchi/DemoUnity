using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;
    public System.Action onDead;

    private void Start() => healthPoint = defaultHealthPoint;

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

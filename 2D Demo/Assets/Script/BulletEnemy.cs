using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float flySpeed = 2;
    public int damage = 3;

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y -= Time.deltaTime * flySpeed; // Bay xuống thay vì bay lên
        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}

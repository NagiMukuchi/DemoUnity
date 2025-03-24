using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireCooldown = 0.5f; // Time between shots
    private float lastFireTime;

    void Update()
    {
        // Check if the player presses the fire button and if cooldown is over
        if (Input.GetKey(KeyCode.Space) && Time.time > lastFireTime + fireCooldown)
        {
            FireBullet();
            lastFireTime = Time.time;
        }
    }

    void FireBullet()
    {
        // Get a bullet from the pool
        GameObject bullet = BulletPool.Instance.GetBullet();
        if (bullet != null)
        {
            // Set bullet position to the player's position
            bullet.transform.position = transform.position + Vector3.forward;
            bullet.transform.rotation = transform.rotation;
        }
    }
}

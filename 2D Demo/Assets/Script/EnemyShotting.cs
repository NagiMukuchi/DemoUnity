using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;

    public Vector3 bulletOffset = Vector3.zero; // Offset for bullets (useful for player shooting)

    public float shootInterval = 3;
    private float lastBulletTime = 0;

    // Update is called once per frame
    void Update()
    {
        UpdateFiring();
        
    }

    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootInterval)
        {
            ShootBullet();
            ShootBullet2();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }


    private void ShootBullet2()
    {
        Instantiate(bulletPrefab2, transform.position + bulletOffset, transform.rotation);
    }
}

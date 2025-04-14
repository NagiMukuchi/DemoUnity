using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 bulletOffset = Vector3.zero; // Offset for bullets (useful for player shooting)

    public float shootInterval = 0.5f;
    private float lastBulletTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) // Allows continuous firing while holding the button
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }
}

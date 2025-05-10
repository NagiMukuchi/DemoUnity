using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{
    public GameObject bulletPrefab;        // Prefab Ball_Fs
    public float bulletSpeed = 10f;        // Sẽ ghi đè tốc độ trong BulletEnemy2 nếu muốn
    public float shootInterval = 2f;
    public int bulletsPerWave = 12;

    private float lastShootTime;

    void Update()
    {
        if (Time.time - lastShootTime >= shootInterval)
        {
            ShootBulletCircle();
            lastShootTime = Time.time;
        }
    }

    private void ShootBulletCircle()
    {
        float angleStep = 360f / bulletsPerWave;
        float angle = angleStep;  // Bắt đầu từ một góc nhỏ hơn 0° để tránh hướng 12h (0°)

        for (int i = 0; i < bulletsPerWave; i++)
        {
            // Tính toán hướng di chuyển của viên đạn
            float dirX = Mathf.Cos(angle * Mathf.Deg2Rad);
            float dirY = Mathf.Sin(angle * Mathf.Deg2Rad);
            Vector3 dir = new Vector3(dirX, dirY, 0).normalized;

            // Offset nhẹ để tránh nằm trong collider boss
            float offset = 0.3f;
            Vector3 spawnPos = transform.position + dir * offset;

            GameObject bullet = Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            // Đặt hướng bay bằng cách chỉnh Rigidbody2D.velocity
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = dir * bulletSpeed;
            }

            // Cập nhật flySpeed trong BulletEnemy2 nếu cần
            BulletEnemy2 bulletScript = bullet.GetComponent<BulletEnemy2>();
            if (bulletScript != null)
            {
                bulletScript.flySpeed = bulletSpeed;
            }

            // Tránh đạn va chạm boss
            Collider2D bossCollider = GetComponent<Collider2D>();
            Collider2D bulletCollider = bullet.GetComponent<Collider2D>();
            if (bossCollider != null && bulletCollider != null)
            {
                Physics2D.IgnoreCollision(bossCollider, bulletCollider);
            }

            angle += angleStep;  // Tiến đến góc tiếp theo
        }
    }

}

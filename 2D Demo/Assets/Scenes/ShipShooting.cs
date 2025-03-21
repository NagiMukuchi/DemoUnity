using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float shootInterval = 0.5f;
    private float lastBulletTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0)&& Time.time - lastBulletTime > shootInterval)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            lastBulletTime = Time.time;
        }
    }

}

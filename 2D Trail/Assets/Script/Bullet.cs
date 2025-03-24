using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 20;
    public float lifespan = 2f; // Bullet will deactivate after 2 seconds

    void OnEnable()
    {
        // Automatically deactivate the bullet after its lifespan
        Invoke("Deactivate", lifespan);
    }

    void Update()
    {
        // Move the bullet upwards
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }

    void Deactivate()
    {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        // Cancel any pending Invoke calls when the bullet is deactivated
        CancelInvoke();
    }
}


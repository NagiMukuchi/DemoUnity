using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        var mousePosition = Input.mousePosition;
        if (mousePosition.x < 100) 
        {
            mousePosition.x = 100;
        }
        else if (mousePosition.x > 980)
        {
            mousePosition.x = 980;
        }

        if (mousePosition.y < 100)
        {
            mousePosition.y = 100;
        }
        else if (mousePosition.y > 980)
        {
            mousePosition.y = 980;
        }

        var worldPoint = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPoint.z = transform.position.z;

        var movement = worldPoint - transform.position;
        if (movement.magnitude <= 0.03)
        {
            transform.position = worldPoint;
        }
        else
        {
            transform.Translate(speed * Time.deltaTime * movement); 
        }
        //var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //worldPoint.z = 0;
        //transform.position = worldPoint;
    }
}


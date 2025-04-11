using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCamera : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    // Start is called before the first frame update
    void Start()
    {
        ShowCamera1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowCamera1()
    {
        Camera1.enabled = true;
        Camera2.enabled = false;

        //Invoke("ShowCamera2", 5f); // Switch to Camera2 after 5 seconds
        Invoke(nameof(ShowCamera2), 2); // Switch to Camera2 after 5 seconds
    }

    void ShowCamera2()
    {
        Camera2.enabled = true;
        Camera1.enabled = false;

        Invoke(nameof(ShowCamera1), 2); // Switch to Camera1 after 2 seconds
    }
}

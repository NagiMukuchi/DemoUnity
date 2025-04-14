using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.LogWarning("This is a warning");
        Debug.LogError("This is an error");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Time.time = {Time.time}, Time.deltaTime = {Time.deltaTime}");

        Debug.Log(this.transform.position.x);
        Debug.Log(this.transform.rotation.y);
    }
}

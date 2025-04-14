using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhepToan : MonoBehaviour
{
    [SerializeField] Text myText;
    float lastTime;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTime >= 1)
        {
            myText.text = $"{1 / Time.deltaTime:####.##}FPS!";
            lastTime = Time.time;
        }
    }


}

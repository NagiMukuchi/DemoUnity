using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StringSample : MonoBehaviour
{
    //[SerializeField] private string message;
    //[SerializeField] private string greeting;
    [SerializeField] string Name = "Nguyen Viet Anh";
    //[SerializeField] private string welcome;
    void Start()
    {
        // Declaration and Initialization 
        //message = "Hello, Unity!";
        string hello = "Hello, "+ "I am ";
        hello = $"{hello} {Name}";

        Debug.Log(hello);
        Debug.Log($"ToUpper: \"{hello.ToUpper()}\"");
        Debug.Log($"ToLower: \"{hello.ToLower()}\"");
        Debug.Log($"SubString(10): \"{hello.Substring(10)}\"");
        Debug.Log($"SubString(9,10): \"{hello.Substring(9,10)}\" {hello.Substring(9,10).Length}");
        Debug.Log($"Replace: \"{hello.Replace("Anh", "Em")}\"");

        string[] words = hello.Split(' ',',').Where(s => !string.IsNullOrEmpty(s)).ToArray();
        for( int i = 0; i < words.Length; i++)
        {
            Debug.Log($"words[{i}] = \"{words[i]}\"");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

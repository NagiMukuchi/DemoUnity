using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorOperators : MonoBehaviour
{
    [SerializeField] private Vector3 vectorA;
    [SerializeField] private Vector3 vectorB;
    [SerializeField] private Vector3 addition;
    [SerializeField] private Vector3 subtraction;
    [SerializeField] private Vector3 multiplication;
    [SerializeField] private Vector3 division;
    // Start is called before the first frame update
    void Start()
    {
        vectorA = new Vector3(1, 2, 3);
        vectorB = new Vector3(4, 5, 6);

        addition = vectorA + vectorB;
        subtraction = vectorA - vectorB;
        multiplication = vectorA * 2;
        division = vectorB / 2;

        Debug.Log("Vector A: " + vectorA);
        Debug.Log("Vector B: " + vectorB);
        Debug.Log("Addition: " + addition);
        Debug.Log("Subtraction: " + subtraction);
        Debug.Log("Multiplication: " + multiplication);
        Debug.Log("Division: " + division);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

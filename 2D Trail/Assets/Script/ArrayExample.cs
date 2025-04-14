using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    [SerializeField] int[] numbers1 = new int[10]; // Array of 10 integers
    [SerializeField] int[] numbers = new int[] { 0,1,2,3,4,5,6,7,8,9 }; // Array of 10 integers

    List<int> numbersList = new List<int>(); // List of integers

    Queue<int> queue = new Queue<int>();
    Stack<int> stack = new Stack<int>();

    // Start is called before the first frame update
    void Start()
    {
        numbers1[0]= 100;
        Debug.Log($"numbers1[0]= {numbers1[0]}");

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log($"numbers[{i}] = {numbers[i]}");
            numbersList.Add(numbers[i]);
        }

        numbersList.Add(999);
        numbersList.AddRange(numbers);
        numbersList.AddRange(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 });
        numbersList.Insert(3, 888);
        numbersList.RemoveAt(7);

        int j = 0;
        foreach (var number in numbers)
        {
            Debug.Log($"foreach number[{j}] = {number}");
            j++;
        }


        numbersList.Add(999);
        Debug.Log($"numbersList.Count= {numbersList.Count}");
        Debug.Log($"numbersList[0]= {numbersList[0]}");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

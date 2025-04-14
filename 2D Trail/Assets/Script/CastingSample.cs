using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int myInt = 10;
        float myFloat = myInt;

        string myString = "106";

        myFloat = 3.8f;
        int myInt2 = (int)myFloat;

        //int myInt3 = int.Parse(myString);


        Debug.Log($"myFloat = {myFloat}");
        Debug.Log($"myInt2 = {myInt2}");
        if(int.TryParse(myString, out int myInt3))
        {
            Debug.Log($"myInt3 = {myInt3}");
        }
        else
        {
            Debug.Log("Failed to parse myString to myInt3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

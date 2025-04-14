using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ProjectAlias = System.Collections.Generic.Dictionary<string, int>;

public class Allias : MonoBehaviour
{
    [SerializeField] ProjectAlias myDic = new();

    Dictionary<string, int> myDic2 = new();
    Dictionary<int, int> myDic3 = new();
    // Start is called before the first frame update
    void Start()
    {
        myDic["key1"] = 123;
        myDic["key2"] = 456;
        myDic["key3"] = 789;


        myDic["key1"] = 0;
        Debug.Log($"myDic[\"key1\"] = {myDic["key1"]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

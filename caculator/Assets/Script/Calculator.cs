using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    private Text txt;
    void Start()
    {
        txt = GetComponent<Text>();
        txt.text = "";
    }

    public void Add(string str)
    {
        txt.text += str;
    }

    public void Clear()
    {
        txt.text = "";
    }
}
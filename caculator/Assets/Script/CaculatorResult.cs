using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class CaculatorResult : MonoBehaviour
{
    [SerializeField] Text CalStr;

    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = this.GetComponent<Text>();
    }

    DataTable dt = new();
    public void Caculate()
    {
        try
        {
            var result = System.Convert.ToDouble(dt.Compute(CalStr.text, null));
            txt.color = Color.white;
            txt.text = result.ToString();
        }
        catch (SyntaxErrorException)
        {
            txt.color = Color.red;
            txt.text = "Syntax Error";
        }
    }
}

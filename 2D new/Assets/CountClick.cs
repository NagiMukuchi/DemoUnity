using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountClick : MonoBehaviour
{
    [SerializeField] Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = count.ToString();
    }

    int count = 0;

    public void OnButtonClick()
    {
        Debug.Log("Button Clicked!");
        this.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
        Invoke(nameof(ResetScale), 0.5f);
        count++;
        myText.text = count.ToString();
    }

    void ResetScale()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

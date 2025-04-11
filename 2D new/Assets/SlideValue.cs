using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SlideValue : MonoBehaviour
{
    private Text myText;
    //public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        myText = this.GetComponent<Text>();

        myText.text = "Slider";

        myText.color = Color.red;

        //var rectTransform = this.GetComponent<RectTransform>();
        //rectTransform.sizeDelta = new Vector2(200, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateValue(float val)
    {
        //myText.text = $"{slider.value:.###}";
        myText.text = $"{val:.###}";
    }
}

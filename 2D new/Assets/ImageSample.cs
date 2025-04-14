using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSample : MonoBehaviour
{
    public Image myImage;
    public Sprite sprite1;
    public Sprite sprite2;

    private bool isSprite1Active = true;

    // Start is called before the first frame update
    void Start()
    {
        myImage.sprite = sprite1;
        StartCoroutine(SwapImageEverySecond());
    }

    IEnumerator SwapImageEverySecond()
    {
        while (true) 
        {
            yield return new WaitForSeconds(1); 
            if (isSprite1Active)
            {
                myImage.sprite = sprite2;
            }
            else
            {
                myImage.sprite = sprite1;
            }
            isSprite1Active = !isSprite1Active; 
        }
    }
}

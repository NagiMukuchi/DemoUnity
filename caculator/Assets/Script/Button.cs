using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text display; // Đối tượng Text hiển thị kết quả

    public void OnButtonClick()
    {
        display.text += "1"; // Thêm số "1" vào Text hiển thị
        Debug.Log("Button Clicked!");
    }
}


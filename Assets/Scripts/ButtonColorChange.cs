using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonColorChange : MonoBehaviour
{
    public Color wantedColor;
    public Image image;

    public void ChangeButtonColor()
    {
       
        image.color = wantedColor;
        
    }
}

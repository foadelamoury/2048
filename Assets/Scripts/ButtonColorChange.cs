using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


  

public class ButtonColorChange : MonoBehaviour
{
    public static int  score;
    // public Color wantedColor;
    // public Image image;

    // public void ChangeButtonColor()
    // {
    //    
    //      image.color = wantedColor;
    //     
    // }
    
    public void DestroyGameObject()
    {   Image boxImage = gameObject.GetComponent<Image>();
        
        Debug.Log("the color of the box  is " + boxImage.color);
        Destroy(transform.gameObject);
        GameController2048.countCellsFilled--;
        
    }
}

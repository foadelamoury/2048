using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill2048 : MonoBehaviour
{

    int value;
    Text valueDisplay;

    public void FillValueUpdate(int valueIn)
    {
        value = valueIn;
        valueDisplay.rtext = value.ToString();
    }
}

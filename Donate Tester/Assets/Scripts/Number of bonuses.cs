using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numberofbonuses : MonoBehaviour
{
    public TMP_Text Text;

    private int _number;

    public void Purchase1Pressed()
    {
        _number++;
        Text.text = _number.ToString();
    }
}   

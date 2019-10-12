using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bonus : MonoBehaviour
{
    private int _number1;

    public void Purchase1Pressed()
    {
        _number1++;
        GameObject.Find("Bonus1").GetComponent<TMP_Text>().text = _number1.ToString();
    }

    private int _number2;

    public void Purchase2Pressed()
    {
        _number2++;
        GameObject.Find("Bonus2").GetComponent<TMP_Text>().text = _number2.ToString();
    }
    private int _number3;

    public void Purchase3Pressed()
    {
        _number3++;
        GameObject.Find("Bonus3").GetComponent<TMP_Text>().text = _number3.ToString();
    }
}

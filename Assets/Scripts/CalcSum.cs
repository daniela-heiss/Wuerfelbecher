using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcSum : MonoBehaviour
{
    int sum;
    public Text sumText;

    private void Start() {
        sum = 0;
        InvokeRepeating("calcSum", 0.0f, 1f);
    }
    void calcSum(){
        sum = 0;
        foreach(var dice in Spawndice.CreatedDice)
        {   
            sum += dice.GetComponent<DiceCalc>().upperVal;
        }
        sumText.text = sum.ToString();  
    }
}

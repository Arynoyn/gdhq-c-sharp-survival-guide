using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    // bill is 40
    // tip is 20% or based on what the user wants
    // calculate total amount
    
    public float billAmount = 40.0f;
    public float tipPercentage = 20.0f;
    private float totalAmount = 0.0f;

    void Start()
    {
        float tipAmount = CalculateTip(billAmount, tipPercentage);
        totalAmount = tipAmount + billAmount;
        Debug.Log($"Your bill is ${billAmount.ToString("F2")} and your {tipPercentage}% tip comes to ${tipAmount.ToString("F2")} so you owe ${totalAmount.ToString("F2")}.");
    }

    private float CalculateTip(float amount, float percentage)
    {
        return amount * (percentage / 100.0f );
    }
}

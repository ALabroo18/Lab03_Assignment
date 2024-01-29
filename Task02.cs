using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class Task02 : MonoBehaviour
{
    public int x;//Price of the book
    public int y;//The number of copies you're buying
    private double discount = 0.4;
    private double ShippingCost;
    private double BookCost;
    private double profit;
    private double NetCost;
    // Start is called before the first frame update
    void Start()
    {
        BookCost = x * (1 - discount);
        //If the number of copies is 1, then the cost should only increase by 3
        if (y == 1)
        {
            ShippingCost = 3;
        }
        //if the number of copies is more than 1, then add the increased cost by 75 cents
        else
        {
            //if each additional copy is 
            ShippingCost = 3 + ((y - 1) * 0.75);
        }
        profit = x * y; //Profit from the number of copies bought by the price

        NetCost = (profit) - (BookCost + ShippingCost);
        Debug.Log($"Cost: {NetCost}, Profit: {profit}");
    }
}
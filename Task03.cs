using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task03 : MonoBehaviour
{
    public int x;
    private int OneDollar;
    private int FiveDollar;
    private int TenDollar;
    private int TwentyDollar;
    private int FiftyDollar;
    private int HundredDollar;
    private int CountDollar;
    // Start is called before the first frame update
    void Start()
    {
        //Divide x by each respective bill to get the number of bills from it
        HundredDollar = x / 100;
        //Constantly update x by modular dividing it by the bill value to see if the value changes 
        x %= 100;
        Debug.Log($"{x}");

        FiftyDollar = x / 50;
        x %= 50;

        TwentyDollar = x / 20;
        x %= 20;

        TenDollar = x / 10;
        x %= 10;

        FiveDollar = x / 5;
        x %= 5;
        OneDollar = x;
        Debug.Log($"100$: {HundredDollar}");
        Debug.Log($"$50: {FiftyDollar}");
        Debug.Log($"$20: {TwentyDollar}");
        Debug.Log($"$10: {TenDollar}");
        Debug.Log($"$5: {FiveDollar}");
        Debug.Log($"$1: {OneDollar}");


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

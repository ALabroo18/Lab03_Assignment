using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class Task01 : MonoBehaviour
{
    public string CourseName;
    public double ModCount;
    public double ReadCount;
    public double QuizCount;
    public double AssignCount;// 
    public int TeachTaught; // Teach Taught should be 0 or 1. 0 if they've taught it before, and 1 otherwise.
    private double ChallengeScore;
    // Start is called before the first frame update
    void Start()
    {
        //30% is counted as .3, and 15% is 0.15.
        //Multiply the number of each category by their percentage
        ModCount =  ModCount * 0.15;
        ReadCount = ReadCount * 0.3;
        QuizCount = QuizCount * 0.15;
        AssignCount = AssignCount * 0.3;
        //Add all the values to get the challenge score.
        ChallengeScore = ModCount + ReadCount + QuizCount + AssignCount + TeachTaught;
        Debug.Log($"Course Name: {CourseName} Score: {ChallengeScore}");
    }
}

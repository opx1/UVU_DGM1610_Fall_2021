using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 20;
        int y = 18;
        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }

        int time = 20;
        if (time < 18)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        int time2 = 22;
        if (time2 <10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time2 < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        string result = (time < 18) ? "Good day." : "Good evening.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

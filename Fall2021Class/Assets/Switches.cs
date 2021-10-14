using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            default:
            case 5:
                Console.WriteLine("Friday");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

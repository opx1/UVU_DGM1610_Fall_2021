using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        Console.WriteLine(cars[1]);
        cars[0] = "Opel";
        Console.WriteLine(cars.Length);
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i <5)
        {
            Console.WriteLine(i);
            i++;
        }

        do
        {
          Console.WriteLine(i);
          i++;
        } while (i < 5);

        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine(j);
        }

        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string j in cars)
        {
            Console.WriteLine(j);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

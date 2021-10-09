using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
public class MainPlayer : MonoBehaviour
{
    public string myName;
    void Start()
    {
      Debug.Log("I am alive and my name is " + myName);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int negation = -num;

        
        Console.WriteLine($"Negation: {negation}");
    }
}

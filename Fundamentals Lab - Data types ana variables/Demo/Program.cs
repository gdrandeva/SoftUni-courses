﻿

using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometers = meters / 1000.0;

            Console.WriteLine($"{kilometers:f2}");

            
        }
    }
}

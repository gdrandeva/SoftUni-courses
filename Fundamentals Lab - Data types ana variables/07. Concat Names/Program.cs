﻿using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{name1}{delimeter}{name2}");

            //Console.Write(name1);
            //Console.Write(delimeter);
            //Console.Write(name2);
        }
    }
}

﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\nWhat is your Name?");
            var username = Console.ReadLine();
            Console.WriteLine($"\nHello {username}!");

            int dayOfYear = DateTime.Now.DayOfYear;

            Console.Write("Day of year: ");
            Console.WriteLine(dayOfYear);
            Console.WriteLine("\nWhat is your\"\" Name?");
        }
    }
}

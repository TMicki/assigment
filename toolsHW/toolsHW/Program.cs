﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolsHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            int value = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the unit: ");
            string unit = Console.ReadLine();
            Console.WriteLine("Enter the conversion desired: ");
            string unitTo = Console.ReadLine();

            if (unit == "kg" && unitTo == "lbs")
            {
                Console.WriteLine(value * 2.2 + " lbs");
            }
            if (unit == "lbs" && unitTo == "kg")
            {
                Console.WriteLine(value * 0.453 + "kg");
            }
            if (unit == "cm" && unitTo == "in")
            {
                Console.WriteLine(value * 0.393 + "in");
            }
            if (unit == "in" && unitTo == "cm")
            {
                Console.WriteLine(value * 2.54 + "cm");
            }
            Console.ReadLine();
        }
    }
}

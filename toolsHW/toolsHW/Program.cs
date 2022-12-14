using System;
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
            //Added list of available conversions
            Console.WriteLine("The following conversions are supported: ");
            Console.WriteLine("kg <=> lbs");
            Console.WriteLine("cm <=> in");
            Console.WriteLine("ml <=> oz");

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
            if (unit == "km" && unitTo == "Mile")
            {
                Console.WriteLine(value + 0.621 + "Mile");
            }
            if (unit == "Mile" && unitTo == "km")
            {
                Console.WriteLine(value * 1.6 + "km");
            }
            if (unit == "m" && unitTo == "yard")
            {
                Console.WriteLine(value * 1.09 + "yard");
            }
            if (unit == "yard" && unitTo == "m")
            {
                Console.WriteLine(value * 0.91 + "m");
            }

            //NR: new conversions
            if (unit == "oz" && unitTo == "ml")
            {
                Console.WriteLine(value * 29.574 + " ml");
            }
            if (unit == "ml" && unitTo == "oz")
            {
                Console.WriteLine((value / 29.574).ToString("F3") + " oz");
            }

            Console.ReadLine();
        }
    }
}

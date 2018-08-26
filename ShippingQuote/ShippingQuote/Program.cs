using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome
            Console.WriteLine("Welcome to Package Express. Please follow instructions below");

            // Package weight logic
            Console.Write("\nEnter the weight of your package: ");
            float weight = float.Parse(Console.ReadLine());
            // Does package weigh over 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read(); // hold
                return;
            }

            // Dimentions
            Console.WriteLine("\nPlease enter package dimentions");
            // Width
            Console.Write("Width: ");
            float width = float.Parse(Console.ReadLine());
            // Height
            Console.Write("Height: ");
            float height = float.Parse(Console.ReadLine());
            // Length
            Console.Write("Lenght:");
            float length = float.Parse(Console.ReadLine());
            // Logic
            if ((width+height+length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.Read(); // hold
                return;
            }

            // Calculate cost
            float total = ((width+height+length) * weight) / 100;
            Console.Write("\nYour estimated total for shipping this package is: $" + total);
            Console.WriteLine("\nThanke you.");
            
            // Hold
            Console.Read();
        }
    }
}

using System;
using System.Text;

namespace SimpleMath
{
    class Program
    {
        static void Main()
        {
            // Multiply by 50
            Console.WriteLine("Enter a number to be multiplied by 50: ");
            int mult50 = 50 * Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result: = " + mult50 + "\n");
            
            // Add 25
            Console.WriteLine("Enter a number to be added to 25: ");
            int add25 = 25 + Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result: = " + add25 + "\n");

            // Divide 12.5
            Console.WriteLine("Enter a number to be divided by 12.5: ");
            double div12p5 = double.Parse(Console.ReadLine()) / 12.5;
            Console.WriteLine("Result: = " + div12p5 + "\n");

            // Check greater than 50
            Console.WriteLine("Enter a number to check if its greater than 50: ");
            bool greater50 = Int32.Parse(Console.ReadLine()) > 50;
            Console.WriteLine("Result: = " + greater50 + "\n");

            // Modulo 7
            Console.WriteLine("Enter a number to get remainder of divide by 7: ");
            int mod7 = Int32.Parse(Console.ReadLine()) % 7;
            Console.WriteLine("Result: = " + mod7 + "\n");

            // Hold
            Console.Read();
        }
    }
}

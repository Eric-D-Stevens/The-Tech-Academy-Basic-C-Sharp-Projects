using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get age
            Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());

            // Get DUI
            Console.WriteLine("\nHave you ever gotten a DUI? (True/False)");
            bool dui = bool.Parse(Console.ReadLine());

            // Get speeding tickets
            Console.WriteLine("\nHow many speeding tickets have you gotten?");
            int tickets = Int32.Parse(Console.ReadLine());

            // Qualification Logic
            bool qualified = (age > 15) && (!dui) && (tickets <= 3);
            Console.WriteLine("\nQualified: " + qualified);

            // Hold
            Console.Read();
           
        }
    }
}

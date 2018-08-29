using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIODrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User, please enter a number: ");
            string number = Console.ReadLine();
            File.WriteAllText(@"..\..\number.txt", number);
            Console.WriteLine("\nReading number from file:");
            string readNumber = File.ReadAllText(@"..\..\number.txt");
            Console.WriteLine("Number: {0}", readNumber);
            Console.Read();
        }
    }
}

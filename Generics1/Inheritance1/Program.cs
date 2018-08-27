using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>();
            emp1.things = new List<string>();
            emp1.things.Add("bill");
            emp1.things.Add("bob");
            emp1.things.Add("bow");

            Employee<int> emp2 = new Employee<int>();
            emp2.things = new List<int>();
            emp2.things.Add(1);
            emp2.things.Add(66);
            emp2.things.Add(23);

            Console.WriteLine("Print String Thins:");
            foreach(string str in emp1.things) { Console.WriteLine(str); }
            Console.WriteLine("\nPrint Int Thins:");
            foreach(int num in emp2.things) { Console.WriteLine(num); }

            Console.Read();
        }
    }
}

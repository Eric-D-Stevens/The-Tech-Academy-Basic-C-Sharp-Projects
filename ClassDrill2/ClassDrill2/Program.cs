using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parameters by name
            int a = 12;
            int b = 13;

            // Output Method Calls
            MathAB math = new MathAB();
            Console.WriteLine("A - B = " + math.SubAB(12, 13));
            Console.WriteLine("A - B = " + math.SubAB(a, b));
            
            Console.Read();
        }
    }
}

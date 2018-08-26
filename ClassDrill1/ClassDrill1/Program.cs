using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse User Inpute
            Console.Write("Please Enter Integer A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("\nPlease Enter Integer B: ");
            int B = int.Parse(Console.ReadLine());

            // Output Method Calls
            MathAB math = new MathAB();
            Console.WriteLine("\n\nA + B = " + math.AddAB(A,B));
            Console.WriteLine("A - B = " + math.SubAB(A,B));
            Console.WriteLine("A * B = " + math.MltAB(A,B));



            Console.Read();
        }
    }
}

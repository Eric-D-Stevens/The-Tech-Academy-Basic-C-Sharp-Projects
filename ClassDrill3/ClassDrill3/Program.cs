using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate and initialize class
            MathA math = new MathA();
            

            // run overloaded methods
            Console.WriteLine("Int: "+math.MltBy(12));
            Console.WriteLine("Dec: "+math.MltBy(Convert.ToDecimal(12.00)));
            Console.WriteLine("Str: "+math.MltBy("12"));

            // hold
            Console.Read();
        }
    }
}

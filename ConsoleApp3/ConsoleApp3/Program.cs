using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            VoidRetrun One = new VoidRetrun();
            Console.WriteLine("Enter a number to be divided by 2: ");
            int input = int.Parse(Console.ReadLine());
            One.divBy2(input);


        }
    }

    public class VoidRetrun
    {
        public void divBy2(int input) { Console.WriteLine(input / 2); }
        public void divBy2Output(int input, out int output) { output = input / 2; Console.WriteLine(input / 2); }
        public void divBy2Output(int input, int input2, out int output) { output = input / input2; Console.WriteLine(input / input2); }
    }

    public static class StaticClass
    {
        
    }
}

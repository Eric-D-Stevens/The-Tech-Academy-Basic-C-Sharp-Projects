using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAB math = new MathAB();

            // Enter String A
            Console.WriteLine("Enter number A: ");
            string As = (Console.ReadLine());

            // Enter String B
            string Bs = (Console.ReadLine());
            Console.WriteLine("Enter number B (Optional): ");

            // Method Calls
            int Ans = 0;
            if (Bs.Length == 0) { int A = Convert.ToInt32(As); Ans = math.AddAB(A); }
            else { int A = Convert.ToInt32(As); int B = Convert.ToInt32(Bs); Ans = math.AddAB(A,B); }

            // Print Result
            Console.WriteLine("Answer: " + Ans);


            // hold
            Console.Read();
            
        }
    }

    public class MathAB
    {
        public int AddAB(int A, int B = 0) { return A+B;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            Console.Write("Enter a number to count to: ");
            int count = int.Parse(Console.ReadLine());
            int i = 0;
            while(i <= count)
            {
                Console.Write(i + " ");
                i++;
            }

            // Do While Loop
            Console.Write("\n\nGuess a number between 1 and 10: ");
            int guess = int.Parse(Console.ReadLine());
            int answer = 3;
            do
            {
                if (guess != answer)
                {
                    Console.Write("\nWrong, guess again: ");
                    guess = int.Parse(Console.ReadLine());
                }
            } while (guess != answer);
        }
    }
}

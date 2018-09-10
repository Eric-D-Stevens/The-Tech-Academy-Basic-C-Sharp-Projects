using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAge = false;
            int age = 0;
            while (!validAge)
            {
                try
                {
                    Console.WriteLine("Pleas enter your age: ");
                    validAge = int.TryParse(Console.ReadLine(), out age);
                    if (!validAge) throw new Exception();
                    if (age == 0) throw new ArgumentException();
                    if (age < 0) throw new NegativeException();
                }
                catch (NegativeException)
                {
                    Console.WriteLine("Quit messing around, you cant be negative age");
                    Console.ReadLine();
                    return;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("You are too young to be on the computer");
                    Console.ReadLine();
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("General Exception");
                    Console.ReadLine();
                    return;

                }

                int yob = 2018 - age;
                Console.WriteLine("Year of Birth = {0}", yob);
                Console.ReadLine();
            }
        }
    }

    class NegativeException : ArgumentException
        {
            public NegativeException()
                : base() { }
        }

}

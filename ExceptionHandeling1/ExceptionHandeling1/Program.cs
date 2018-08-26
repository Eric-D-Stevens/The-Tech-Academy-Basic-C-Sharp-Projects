using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 21, 11, 17, 12, 66, 77, 34, 754, 3234, 777, 99 };
            

            try
            {
                Console.WriteLine("Please enter a number to divide list values by: ");
                int userIn = int.Parse(Console.ReadLine());
                foreach (int num in intList)
                {
                    Console.WriteLine(num / userIn);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                return;
            }

            finally
            {
                Console.WriteLine("Exiting try/catch statement without exception");
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Current Day of the Week: ");
            string dayIn = Console.ReadLine();

            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayIn);
                Console.WriteLine(day);
                
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week (e.x.: Sunday)");

            }
            Console.Read();
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

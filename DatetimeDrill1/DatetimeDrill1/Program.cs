using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Time at program start: {0}", now);
            Console.Write("\nPlease enter a number of hours: ");
            int hours = int.Parse(Console.ReadLine());
            TimeSpan hrs = new TimeSpan(hours, 0, 0);
            DateTime nowPlusHours = DateTime.Now + hrs;
            Console.Write("Current Time Plus Hours Entered: {0}", nowPlusHours);
            Console.Read();



        }
    }
}

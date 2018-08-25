using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Begin Program
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            float p1HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            float p1HoursWorked = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            // Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            float p2HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week:");
            float p2HoursWorked = float.Parse(Console.ReadLine());

            // Calculate Salaries
            float p1Salary = p1HoursWorked * p1HourlyRate;
            float p2Salary = p2HoursWorked * p2HourlyRate;

            // Person 1 Salary
            Console.WriteLine("\nPerson 1 Weekly Salary: $" + p1Salary);

            // Person 2 Salary
            Console.WriteLine("Person 2 Weekly Salary: $" + p2Salary + "\n");

            // Who Makes More
            Console.WriteLine("Person 1 makes more than Person 2: " + (p1Salary > p2Salary));
            Console.Read();
            
        }
    }
}

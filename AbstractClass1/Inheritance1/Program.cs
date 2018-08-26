using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.SayName();
            Console.Read();
        }
    }
}

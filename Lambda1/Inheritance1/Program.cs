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
            // List of employees
            List<Employee> empList = new List<Employee>();

            // Add employees to list using constructor
            empList.Add(new Employee("Joe", "Smith", 1));
            empList.Add(new Employee("Mary", "Stevens", 2));
            empList.Add(new Employee("Bob", "Cuellar", 3));
            empList.Add(new Employee("Eric", "Stevens", 4));
            empList.Add(new Employee("Ryan", "Gonzales", 5));
            empList.Add(new Employee("Emily", "Morrison", 6));
            empList.Add(new Employee("Joe", "Jackson", 7));
            empList.Add(new Employee("Ronald", "Limo", 8));
            empList.Add(new Employee("Gary", "Del'Abate", 9));
            empList.Add(new Employee("Ralph", "Cerelli", 10));

            // New list of Joes Using foreach
            List<Employee> forEmpList = new List<Employee>();
            foreach(Employee emp in empList)
            {
                if(emp.FirstName == "Joe")
                {
                    forEmpList.Add(emp);
                }
            }

            // New list of Joes Using Lambda Function
            List<Employee> lambdaJoeList = empList.Where(x => x.FirstName == "Joe").ToList();

            // New List of Employees with high ID numbers
            List<Employee> lambdaHighIDList = empList.Where(x => x.Id > 5).ToList();


            //------------------------------------------------------------------------//
            // See if new lists Are by reference
            Console.WriteLine(empList[0].FirstName + empList[0].LastName);
            Console.WriteLine(lambdaJoeList[0].FirstName + empList[0].LastName);
            lambdaJoeList[0].FirstName = "Hellena";
            Console.WriteLine(empList[0].FirstName + empList[0].LastName);
            Console.WriteLine(lambdaJoeList[0].FirstName + empList[0].LastName);

            // Conclusion -- Yes, the results of the operations above do not create 
            // new objects. These new lists are collections of pointers to origional
            // Employee() objects. In other words, changing an objects state in any 
            // of the lists will be reflected in all lists containing that object.
            //------------------------------------------------------------------------//

            Console.Read();
        }
    }
}

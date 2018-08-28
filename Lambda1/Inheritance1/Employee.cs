using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public Employee(string FirstName, string LastName, int Id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }
        
    }
}

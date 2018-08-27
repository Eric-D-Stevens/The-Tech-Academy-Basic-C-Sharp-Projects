using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Employee<T> : Person
    {
        public List<T> things { get; set; } 
        public int Id { get; set; }
    }
}

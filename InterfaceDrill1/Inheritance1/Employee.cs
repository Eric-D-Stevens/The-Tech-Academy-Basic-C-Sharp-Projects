using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Employee");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("I HATE MY JOB!! I QUIT!! WHOS COMIN' WITH ME?!");
        }
    }
}

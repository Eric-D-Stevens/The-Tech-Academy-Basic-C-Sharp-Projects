using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Const

            // Person 1 input
            const string welcome = "Welcome persons, pleas enter some information: ";
            Console.WriteLine("Person 1, what is your name:");
            string p1name = Console.ReadLine();
            Console.WriteLine("What is your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("do you like beer");
            bool beer = bool.Parse(Console.ReadLine());

            // Person 2 input
            Console.WriteLine("Person 2, what is your name:");
            string p2name = Console.ReadLine();
            Console.WriteLine("What is your age");
            int age2 = int.Parse(Console.ReadLine());

            // using var keyword
            var person1 = new Person(p1name, age, beer);
            var person2 = new Person(p2name, age2);

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool LikeBeer { get; set; }

        public Person (string name, int age, bool beer)
        {
            Name = name;
            Age = age;
            LikeBeer = beer;
        }

        public Person (string name, int age) : this(name, age, true)
        {

        }
    }
}

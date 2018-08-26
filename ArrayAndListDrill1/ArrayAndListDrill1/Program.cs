using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize arrays
            string[] strArr = { "red", "green", "blue", "yellow", "orange", "magenta", "black", "brown", "grey", "purple" };
            int[] intArr = {10,9,8,7,6,5,4,3,2,1};

            // Get user input
            // Color
            Console.Write("Enter a number between 1 and 10 for a color: ");
            int colorIn = int.Parse(Console.ReadLine());
            if(colorIn > 9 || colorIn < 0)
            {
                Console.WriteLine("Index out of array bounds");
                Console.Read();
                return;
            }
            Console.WriteLine("Color: " + strArr[colorIn - 1]);
            // Number
            Console.Write("\nEnter a number between 1 and 10 for a number: ");
            int numberIn = int.Parse(Console.ReadLine());
            if (numberIn > 9 || numberIn < 0)
            {
                Console.WriteLine("Index out of array bounds");
                Console.Read();
                return;
            }
            Console.WriteLine("number: " + intArr[numberIn - 1]);

            // List of strings
            List<string> mylist = new List<string>(new string[] 
                { "Bear", "Puffin", "Spider", "Fish", "Monkey"});
            Console.Write("\nEnter a number between 1 and 5 for an Animal: ");
            numberIn = int.Parse(Console.ReadLine());
            Console.WriteLine("Animal: " + mylist[numberIn - 1]);
            Console.Read();
        }
    }
}

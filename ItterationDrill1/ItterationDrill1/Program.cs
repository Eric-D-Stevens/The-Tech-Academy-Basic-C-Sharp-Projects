using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItterationDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1D String array and user concatination loops
            string[] strArr = { "hello", "world", "this", "is", "a", "test" };
            Console.WriteLine("Please Enter Some Text: ");
            string userStr = Console.ReadLine();
            for(int i=0; i < strArr.Length; i++){strArr[i] += userStr;}
            for(int i=0; i < strArr.Length; i++) { Console.WriteLine(strArr[i]); }

            // Infinite Loop
            //while (1) { Console.Write("Hello World! ");
            
            // Fixed Infinite Loop
            int m = 0;
            while (m < 10) { Console.Write("Hello World! "); m++; }

            // Loop with less than operator
            for(int j=0; j<10; j++) { Console.Write("Hello World! "); }

            // Loop with less than or equal to opperator
            for (int j=0; j<=10; j++) { Console.Write("Hello World! "); }

            // List of Strings with error checking
            List<string> strList = new List<string> { "cat", "dog", "mouse", "chicken", "cow" };
            Console.WriteLine("\n\nSearch for a common farm animal: ");
            string userGuess = Console.ReadLine();
            // search
            for(int i=0; i<strList.Count; i++)
            {
                if(strList[i] == userGuess) { Console.WriteLine("Index of Value: " + i); break; } // break ends execution
                if (i == strList.Count - 1) { Console.WriteLine("Item does not exist in list"); } // works with break as no find message
            }

            // New List of Strings with error checking
            List<string> strList2 = new List<string> { "cat", "dog", "mouse", "chicken", "cow", "dog", "mouse", "chicken", "cow" };
            Console.WriteLine("Search for a common farm animal: ");
            string userGuess2 = Console.ReadLine();
            // search
            bool exists = false;
            for (int i = 0; i < strList2.Count; i++)
            {
                if (strList2[i] == userGuess2) { Console.WriteLine("Index of " + userGuess2 + ": " + i); exists = true; } // break ends execution
                if (i == strList2.Count - 1 && !exists) { Console.WriteLine("Item does not exist in list"); } // 
            }

            // For Each Loop
            List<string> strList3 = new List<string> { "cat", "dog", "mouse", "chicken", "cow", "dog", "mouse", "chicken", "cow" };
                // I am not sure what this question is asking.
                // The only way I can think of to solve this would be with a doubly embedded for loop


            Console.Read();
        }
    }
}

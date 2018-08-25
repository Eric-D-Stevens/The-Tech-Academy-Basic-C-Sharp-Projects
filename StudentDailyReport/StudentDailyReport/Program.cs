using System;
using System.Text;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            // Prompt
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");

            // Get Course in string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Get Page as int
            Console.WriteLine("What page number?");
            int page = Int32.Parse(Console.ReadLine());

            // Get Help as bool
            Console.WriteLine("What Do you need help with anything? Please answer \"true\" or \"false\"");
            bool help = Boolean.Parse(Console.ReadLine());

            // Get Positives in string
            Console.WriteLine("Where there any positive experiences you'd like to share? Please be specific");
            string positives = Console.ReadLine();

            // Get Feedback in string
            Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            string feedback = Console.ReadLine();

            // Get Hours as byte
            Console.WriteLine("How many hours did you study today?");
            byte hours = Byte.Parse(Console.ReadLine());

            // Thank you
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // hold
            Console.Read();

        }
    }
}

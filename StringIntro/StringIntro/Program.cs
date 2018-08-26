using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatinate 3 strings
            string line1 = "We wear the mask that grins and lies.";
            string line2 = "It hides our cheeks, ";
            string line3 = "and shades our eyes.";
            string cat = line1 + line2 + line3;
            Console.WriteLine(cat);

            // Convert to upper case
            string upper = cat.ToUpper();
            Console.WriteLine(upper);

            // String Builder
            StringBuilder sb = new StringBuilder();
            sb.Append("We wear the mask that grins and lies, " +
                "It hides our cheeks and shades our eyes,— " +
                "This debt we pay to human guile; " +
                "With torn and bleeding hearts we smile, " +
                "And mouth with myriad subtleties."); 
            sb.Append(" Why should the world be over-wise, " +
                "In counting all our tears and sighs? " +
                "Nay, let them only see us, while " +
                "We wear the mask.");
            sb.Append(" We smile, but, O great Christ, our cries " +
                "To thee from tortured souls arise. " +
                "We sing, but oh the clay is vile " +
                "Beneath our feet, and long the mile; " +
                "But let the world dream otherwise, " +
                "We wear the mask!");
            Console.WriteLine(sb);

            // Hold
            Console.Read();
        }
    }
}

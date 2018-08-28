using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            Number x = new Number();
            x.Amount = 123.123M;
        }

    }

    public struct Number
    {
        public decimal Amount { get; set; }
    }
}

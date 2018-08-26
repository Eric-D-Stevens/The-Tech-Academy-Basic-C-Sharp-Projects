using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    class MathA
    {
        public int MltBy(int A) { return A * 3; }
        public int MltBy(decimal A) { return Convert.ToInt32(A * 7); }
        public int MltBy(string A) { return Convert.ToInt32(A) * 11; }

    }
}

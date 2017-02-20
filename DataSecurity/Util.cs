using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity
{
    class Util
    {
        public static int Xor(int a, int b)
        {
            return a & ~b | ~a & b;
        }
    }
}

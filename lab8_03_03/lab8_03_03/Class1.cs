using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_03_03
{
     public static class Class1
     {
        public static long Factorial(int n)
        {
            long p = 1;
            for (int i = 1; i < n; i++)
                p = p * i;
            return p;
        }
     }
}

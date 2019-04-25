using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Min
    {
        public Min()
        {
        }
        public int GetMin(double a, double b)
        {
            int a1 = int.Parse(a.ToString());
            int b1 = int.Parse(b.ToString());
            int k1 = a1 % b1;
            int k2 = 0, d = 0, min = 0;
            if (a1 > 0)
            {
                k2 = ((a1 / b1 + 1) * b1) % a1;
                d = MinInterval(k1, k2);
                
            }
            else if (a1 < 0)
            {
                k2 = ((a1 / b1 - 1) * b1) % a1;
                d = MaxInterval(k1, k2);
            }
            if (d == k1)
            {
                min = a1 - k1;
            }
            else if (d == k2)
            {
                min = a1 + k2;
            }
            return min;
        }
        public int MinInterval(int a, int b)
        {
            if (a >= b) return b;
            else return a;
        }
        public int MaxInterval(int a, int b)
        {
            if (a < b) return b;
            else return a;
        }
    }
}

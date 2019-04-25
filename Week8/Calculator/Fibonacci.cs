using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Fibonacci
    {
        public Fibonacci()
        {
        }
        public int GetNumber(int index)
        {
            int i = 2;
            int[] a = new int[index + 1];
            a[0] = 0;
            a[1] = 1;
            while(i <= index)
            { 
                a[i] = a[i - 1] + a[i - 2];
                i++;
            }
            return a[index];
        }
    }
}

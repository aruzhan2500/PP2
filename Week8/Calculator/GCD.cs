using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class GCD
    {
        public GCD()
        {
        }
        public int GetGCD(double a, double b)
        {
            int a1 = int.Parse(a.ToString());
            int b1 = int.Parse(b.ToString());
            int gcd = 0;
            if (a1 >= b1)
            {
                if (b1 == 0) return a1;
                gcd = a1 % b1;
                return GetGCD(gcd, b1);
            }
            else
            {
                if (a1 == 0) return b1;
                gcd = b1 % a1;
                return GetGCD(a1, gcd);
            }
        }
        public string Coprime(double a, double b)
        {
            GCD gcd = new GCD();
            if (gcd.GetGCD(a, b) > 1)
            {
                return "YES";
            }
            return "NO";
        }
    }
}


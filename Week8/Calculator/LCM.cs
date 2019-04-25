using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class LCM
    {
        public LCM()
        {
        }
        public int GetLCM(double a, double b)
        {
            int a1 = int.Parse(a.ToString());
            int b1 = int.Parse(b.ToString());
            GCD gcd = new GCD();
            int gcdnum = gcd.GetGCD(a1, b1);
            int lcm = 0;
            lcm = (a1 * b1) / gcdnum;
            return lcm;
        }
    }
}

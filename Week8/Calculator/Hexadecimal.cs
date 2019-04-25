using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Hexadecimal
    {
        public Hexadecimal()
        {
        }
        public string Bits(int a)
        {
            string output = "";
            string bit;
            if (a < 10) return "0";
            while (a > 0)
            {
                if (a % 16 == 10) bit = "A";
                else if (a % 16 == 11) bit = "B";
                else if (a % 16 == 12) bit = "C";
                else if (a % 16 == 13) bit = "D";
                else if (a % 16 == 14) bit = "E";
                else if (a % 16 == 15) bit = "F";
                else bit = (a % 16).ToString();
                output = bit + output;
                a = a / 16;
            }
            return output;
        }
    }
}

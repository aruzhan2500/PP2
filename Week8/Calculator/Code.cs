using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Code
    {
        int type;
        public Code(int type)
        {
            this.type = type;
        }
        public string Bits(int a)
        {
            string output = "";
            string bit;
            if (a < type) return "0";
            while (a >= 1)
            {
                bit = (a % type).ToString();
                output = bit + output;
                a = a / type;
            }
            return output;
        }
    }
}

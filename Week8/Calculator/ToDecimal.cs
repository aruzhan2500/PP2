using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ToDecimal
    {
        int type;
        public ToDecimal(int type)
        {
            this.type = type;
        }
        public int GetDecimal(string a)
        {
            char[] chars = a.ToCharArray();
            int[] numbers = new int[chars.Length];
            for (int j = 0; j < chars.Length; j++)
            {
                numbers[j] = ConvertToInt(chars[chars.Length - 1 - j]);
            }
            int i = 1;
            int output = numbers[0];
            while (i != numbers.Length)
            {
                output += numbers[i] * type;
                type *= type;
                i++;
            }
            return output;
        }
        public int ConvertToInt(char c)
        {
            int a = 0;
            if (c == 'A') return a = 10;
            if (c == 'B') return a = 11;
            if (c == 'C') return a = 12;
            if (c == 'D') return a = 13;
            if (c == 'E') return a = 14;
            if (c == 'F') return a = 15;
            return a = int.Parse(c.ToString());
        }
    }
}

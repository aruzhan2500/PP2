using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        int x;
        int y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 59)
                {
                    x = 0;
                }
                else if (value < 0)
                {
                    x = 59;
                }
                else
                {
                    x = value;
                }
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 22)
                {
                    y = 0;
                }
                else if (value < 0)
                {
                    y = 22;
                }
                else
                {
                    y = value;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //enters a line by converting string to integer  
            string[] a = Console.ReadLine().Split(' '); //enters an array by splitting spaces from the line
            for (int i = 0; i < n; i++) //operator which is responsible for each index
            {
                Console.Write(a[i] + ' ' + a[i] + ' ');//shows every element repeated
            }
            Console.ReadKey();//to not to close console

        }
    }
}

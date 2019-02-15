using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //enters a line by converting string to integer  
            for (int i = 0; i < n; i++) //operator which is responsible for every first index
            {
                for (int j = 0; j <= i; j++) //operator which is responsible for every second index
                {
                    Console.Write("[*]");//shows [*]
                }
                Console.WriteLine();//goes to the next line
            }
        }
    }
}

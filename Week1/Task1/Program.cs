using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool Prime(int n)//creates a new bool function
        {
            if (n == 0 || n == 1) return false;//if n=0 or n=1 the function will continue
            for (int i = 2; i <= Math.Sqrt(n); i++)//operator that responsible for each index from 2 to root of n
            {
                if (n % i == 0) return false;//if n divides on i the function will continue
            }
            return true;//for the other cases the function will work
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//enters a line by converting string to integer
            string[] a = Console.ReadLine().Split(' ');//enters an array by splitting spaces from the line
            int[] b = new int[n];//new integer array
            int cnt = 0;//an integer to count
            string output = "";//a string to write an output line
            for (int i = 0; i < n; i++)//for each index
            {
                b[i] = int.Parse(a[i]);//converts string to integer array
                if (Prime(b[i]))//if the function is true or will work
                {
                    cnt++;//counts every prime number
                    output += a[i] + ' ';//adds every prime number and space
                }
            }
            Console.WriteLine(cnt);//shows the number of primes
            Console.WriteLine(output);//shows the prime numbers
            Console.ReadKey();//to not to close console
        }
    }
}

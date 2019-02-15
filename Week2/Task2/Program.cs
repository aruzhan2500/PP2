using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool Prime(int n)//new function Prime
        {
            if (n == 0 || n == 1) return false;//0 and 1 are not prime numbers
            for (int i = 2; i <= Math.Sqrt(n); i++)//for each index till the root of n
            {
                if (n % i == 0) return false;//if n divides by another integer it is false
            }
            return true;//in other case it is true
        }
        static void Main(string[] args)
        {
            string[] nums = File.ReadAllText(@"C:\Users\Aruzhan\desktop\number.txt").Split(' ');//a new array that will read from text file
            string output = "";//empty string
            int[] nums2 = new int[nums.Length];//new integer array
            for (int i = 0; i < nums.Length; i++)//for each index of nums array
            {
                nums2[i] = int.Parse(nums[i]);//changes to integer each element
                if (Prime(nums2[i]))//if integer element is true
                {
                    output += nums[i] + ' ';//adds char element to empty string
                }
            }
            File.WriteAllText(@"C:\Users\Aruzhan\desktop\output.txt", output);//creates a new text file that will show prime numbers
            Console.ReadKey();//to not to close console/
        }
    }
}

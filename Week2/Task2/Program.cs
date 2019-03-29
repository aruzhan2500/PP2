using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = File.ReadAllText(@"C:\Users\Aruzhan\Desktop\input\input.txt").Split(' ');
            int[] nums = new int[numbers.Length];
            string output = "";
            for (int i = 0; i < numbers.Length; ++i)
            {
                nums[i] = int.Parse(numbers[i]);
                if (Prime(nums[i]))
                {
                    output += numbers[i] + " ";
                }
            }
            FileStream fs = File.Create(@"C: \Users\Aruzhan\Desktop\input\output.txt");
            fs.Close();
            File.WriteAllText(@"C: \Users\Aruzhan\Desktop\input\output.txt", output);
            Console.Read();
        }

        private static bool Prime(int v)
        {
            if (v < 2) return false;
            else
            {
                for (int i = 2; i < Math.Sqrt(v); ++i)
                {
                    if (v % i == 0) return false;
                }
            }
            return true;
        }
    }
}
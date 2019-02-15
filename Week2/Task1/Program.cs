using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static bool Palindrome(string s)//new function palindrome
        {
            for (int i = 0; i < s.Length; i++)//for each index of string
            {
                if (s[i] != s[s.Length - 1 - i]) return false;//checks for palindrome or not
            }
            return true;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Aruzhan\desktop\text.txt");//reads a text from txt file
            if (Palindrome(text))//if it is true
            {
                Console.WriteLine("Yes");//writes Yes
            }
            else//if false
            {
                Console.WriteLine("No");//writes No
            }
            Console.ReadKey();//to not to close console
        }
    }
}

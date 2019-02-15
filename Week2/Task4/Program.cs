using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = File.Create(@"c:\Users\Aruzhan\Desktop\input\source.txt");//creates a file
            c.Close();//closes the file
            File.Copy(@"c:\Users\Aruzhan\Desktop\input\source.txt", @"C:\Users\Aruzhan\Desktop\output\source.txt");//copies from source to destination
            File.Delete(@"c:\Users\Aruzhan\Desktop\input\source.txt");//deletes the original file
        }
    }
}

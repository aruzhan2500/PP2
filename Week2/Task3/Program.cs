using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\users\Aruzhan\desktop\pp2");//information about folder
            StringPath(dir, 0);//return function
            Console.ReadKey();//to not to close console
        }
        static void StringPath(FileSystemInfo fsi, int k)//new function
        {
            string line = new string(' ', k);//string with k elements which are ' '
            line += fsi.Name;//adds files' name
            Console.WriteLine(line);//writes their name
            if (fsi is DirectoryInfo)//if file is directory
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos();//gets information about folder
                foreach (var t in items)//in that folder
                {
                    StringPath(t, k + 4);//their name with TAB 
                }
            }
        }
    }
}

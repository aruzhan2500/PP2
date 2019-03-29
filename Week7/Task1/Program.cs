using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; ++i)
            {
                threads[i] = new Thread(DoIt);
                threads[i].Name = "Thread " + i;
                threads[i].Start();
            }
            Console.Read();
        }

        private static void DoIt()
        {
            Thread.Sleep(1000);
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
    }
}

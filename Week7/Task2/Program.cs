using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class myThread
        {
            Thread threadField;
            public int num;
            public myThread(string name)
            {
                threadField = new Thread(DoIt);
                threadField.Name = name;
            }

            public void startThread()
            {
                threadField.Start();
            }

            private void DoIt()
            {
                
                for (int i = 1; i <= 4; ++i)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " vyvodit " + i);
                    
                }
                Console.WriteLine(Thread.CurrentThread.Name + " zavershilsya");
                
            }
        }
        static void Main(string[] args)
        {
            myThread t1 = new myThread("Thread 1");
            myThread t2 = new myThread("Thread 2");
            myThread t3 = new myThread("Thread 3");
            myThread t4 = new myThread("Thread 4");

            t1.startThread();
            t2.startThread();
            t3.startThread();
            t4.startThread();

            Console.Read();
        }
    }
}

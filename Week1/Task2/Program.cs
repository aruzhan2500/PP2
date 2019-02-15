using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student//creates a new class
    {
        public string name;//a new field
        public string id;
        public int year;

        public Student(string name, string id)//creates a constructor
        {
            this.name = name;//assign a value
            this.id = id;//assign a value
        }

        public void IncYear()//creates a method of increment of year
        {
            year++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}

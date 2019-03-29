using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }

        static void F1()
        {
            ComplexNum num = new ComplexNum();
            num.a = int.Parse(Console.ReadLine());
            num.b = int.Parse(Console.ReadLine());

            FileStream fs = new FileStream("Complex.txt", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(ComplexNum));
            xml.Serialize(fs, num);
            fs.Close();
        }

        static void F2()
        {
            FileStream fs = new FileStream("Complex.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(ComplexNum));
            ComplexNum complexNum = xml.Deserialize(fs) as ComplexNum;
            Console.WriteLine(complexNum.GetLetter());
            Console.Read();
            fs.Close();
        }
    }
    [Serializable]
    public class ComplexNum
    {
        public int a;
        public int b;
        public ComplexNum()
        {
        }

        public string GetLetter()
        {
            return a + " + " + b + 'i';
        }
    }
}


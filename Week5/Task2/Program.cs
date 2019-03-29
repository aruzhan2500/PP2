using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    public class Mark
    {
        public int fieldPoints;
        public string letter;

        public Mark()
        {
        }
        public Mark(int point)
        {
            this.fieldPoints = point;
        }

        public string GetLetter()
        {
            if (fieldPoints < 25 && fieldPoints >= 0)
            {
                letter = "F";
                return letter;

            }
            if (fieldPoints < 50 && fieldPoints >= 25)
            {
                letter = "Fx";
                return letter;

            }
            if (fieldPoints < 55 && fieldPoints >= 50)
            {
                letter = "D-";
                return letter;

            }
            if (fieldPoints < 60 && fieldPoints >= 55)
            {
                letter = "D+";
                return letter;

            }
            if (fieldPoints < 65 && fieldPoints >= 60)
            {
                letter = "C-";
                return letter;

            }
            if (fieldPoints < 70 && fieldPoints >= 65)
            {
                letter = "C";
                return letter;

            }
            if (fieldPoints < 75 && fieldPoints >= 70)
            {
                letter = "C+";
                return letter;

            }
            if (fieldPoints < 80 && fieldPoints >= 75)
            {
                letter = "B-";
                return letter;

            }
            if (fieldPoints < 85 && fieldPoints >= 80)
            {
                letter = "B";
                return letter;

            }
            if (fieldPoints < 90 && fieldPoints >= 85)
            {
                letter = "B+";
                return letter;

            }
            if (fieldPoints < 95 && fieldPoints >= 90)
            {
                letter = "A-";
                return letter;

            }
            if (fieldPoints <= 100 && fieldPoints >= 95)
            {
                letter = "A";
                return letter;

            }
            else
            {
                letter = "Does not exist!";
                return letter;

            }
        }
        public String ToString()
        {
            return fieldPoints + " is " +GetLetter();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }

        private static void F1()
        {
            Mark M1 = new Mark(83);
            Mark M2 = new Mark(98);
            Mark M3 = new Mark(75);
            Mark M4 = new Mark(72);

            List<Mark> markss = new List<Mark>();
            markss.Add(M1);
            markss.Add(M2);
            markss.Add(M3);
            markss.Add(M4);
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, markss);
            for(int i=0; i<markss.Count(); ++i)
            {
                Console.WriteLine(markss[i].ToString());
            }
            fs.Close();
        }
        private static void F2()
        {
            List<Mark> m;
            FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            m = xs.Deserialize(fs) as List<Mark>;
            for(int i=0; i<m.Count(); ++i)
            {
                Console.WriteLine(m[i].ToString());
            }
            Console.ReadKey();
            fs.Close();
        }
    }
}

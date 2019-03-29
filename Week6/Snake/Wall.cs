using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall : GameObject
    {
        public Wall(char sign) : base(sign)
        {
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {
            string name = string.Format(@"C:\Users\Aruzhan\Desktop\cpp\PP2\Week6\Snake\Levels\Level{0}.txt", level);
            StreamReader reader = new StreamReader(name);
            int y = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        body.Add(new Point { X = x, Y = y });
                    }
                }
                y++;
            }
            reader.Close();
        }
    }
}

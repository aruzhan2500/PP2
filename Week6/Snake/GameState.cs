using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    class GameState
    {
        Worm worm = new Worm('0');
        Food food = new Food('F');
        Wall wall = new Wall('#');
        int score = 0;
        public GameState()
        {
            Console.SetWindowSize(60, 30);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
        }

        public void Draw()
        {
            worm.Draw();
            food.Draw();
            wall.Draw();
        }

        public void CheckCollision()
        {
            if (worm.CheckIntersection(food.body[0]))
            {
                food.Generate();
                worm.Eat(food.body[0]);
            }
        }

        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    worm.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    worm.Move(1, 0);
                    break;
                case ConsoleKey.Escape:
                    FileStream fs = new FileStream("Score.txt", FileMode.Create, FileAccess.Write);
                    XmlSerializer xml = new XmlSerializer(typeof(Score));
                    xml.Serialize(fs, xml);
                    Environment.Exit(0);
                    fs.Close();
                    break;
            }
            CheckCollision();
        }
    }
}

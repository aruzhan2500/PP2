using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class ShowBanner
    {
        public string username;

        public ShowBanner()
        {
            Console.WriteLine("Hello, This is a GAME SNAKE! Please write your username:");
            username = Console.ReadLine();
            Console.WriteLine("Hi, {0}!Press any key to play. GOOD LUCK!", username);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

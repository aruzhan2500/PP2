﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState gameState = new GameState();
            ShowBanner showBanner = new ShowBanner();
           
            while (true)
            {
                gameState.Draw();

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                gameState.PressedKey(consoleKeyInfo);

            }
        }
    }
}

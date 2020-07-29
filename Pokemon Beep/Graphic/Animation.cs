using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Pokemon_Beep.Graphic
{
    class Animation
    {
        public void wildPokemonBattleAnimation()
        {
            int xMin = 2;
            int xMax = 81;
            int yMin = 1;
            int yMax = 28;

            Utilities.changeForegroundColor(255, 255, 255);
            Console.SetCursorPosition(40, 13);
            Console.Write("[!]");
            System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < 900; i++)
            {
                int x = Utilities.RandomNumber(xMin, xMax);
                int y = Utilities.RandomNumber(yMin, yMax);
                Console.SetCursorPosition(x, y);
                Console.Write("█");
                System.Threading.Thread.Sleep(2);
            }
            Utilities.clearConsole();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TrueColorConsole;

namespace Pokemon_Beep.Graphic
{
    class Animation
    {
        public void wildPokemonBattleAnimation()
        {
            int xMin = 2;
            int xMax = 80;
            int yMin = 1;
            int yMax = 28;

            VTConsole.SetColorForeground(Color.White);
            Console.SetCursorPosition(40, 13);
            VTConsole.Write("[!]");
            System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < 900; i++)
            {
                int x = Utilities.RandomNumber(xMin, xMax);
                int y = Utilities.RandomNumber(yMin, yMax);
                Console.SetCursorPosition(x, y);
                VTConsole.Write("█");
                System.Threading.Thread.Sleep(2);
            }
            Utilities.clearConsole();
        }
    }
}

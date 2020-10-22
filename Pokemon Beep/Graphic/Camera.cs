using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Graphic
{
    class Camera
    {
        private Background background;
        public Camera(Background background)
        {
            this.background = background;
        }
        public void printBackground(int posX, int posY)
        {
            for (int x = 2; x < 81; x++)
            {
                int xPrint = posX - 40;
                int yPrint = posY - 13;
                for (int y = 1; y < 28; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(background.Colors[(xPrint + x - 2), (yPrint + y - 1)] + background.Characters[(xPrint + x - 2), (yPrint + y - 1)]);
                }
            }
        }
    }
}

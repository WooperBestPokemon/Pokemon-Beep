﻿using System;
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
            List<StringBuilder> stringBuilders = new List<StringBuilder>();


            for (int y = 1; y < 28; y++)
            {

                int xPrint = posX - 40;
                int yPrint = posY - 13;
                string line = "";
                for (int x = 2; x < 81; x++)
                {
                    //If you see farther than the char[,] It will write an empty space instead of crashing
                    if((xPrint + x - 2) < 0 || background.Characters.GetLength(0) <= (xPrint + x - 2) || (yPrint + y - 1) < 0 || background.Characters.GetLength(1) <= (yPrint + y - 1))
                        line += " ";
                    else
                        line += background.Colors[(xPrint + x - 2), (yPrint + y - 1)] + background.Characters[(xPrint + x - 2), (yPrint + y - 1)];
                }
                stringBuilders.Add(new StringBuilder(line));
            }
            for (int i = 1; i < stringBuilders.Count + 1; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(stringBuilders[i - 1]);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    public static class Utilities
    {
        //CopyRight : https://stackoverflow.com/questions/767999/random-number-generator-only-generating-one-random-number/768001#768001
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
        //Graphic
        public static void clearConsole()
        {
            for (int i = 1; i < 28; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write("                                                                               ");
            }            
        }
        public static void changeBackgroundColor(int r, int g, int b)
        {
            Console.Write("\x1b[48;2;" + r + ";" + g + ";" + b + "m");
            clearConsole();
        }
        public static void changeForegroundColor(int r, int g, int b)
        {
            Console.Write("\x1b[38;2;" + r + ";" + g + ";" + b + "m");
        }
    }
}

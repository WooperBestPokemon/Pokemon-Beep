using System;
using System.Collections.Generic;
using System.Text;
using TrueColorConsole;

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
        public static void clearConsole()
        {
            for (int i = 1; i < 28; i++)
            {
                Console.SetCursorPosition(2, i);
                VTConsole.Write("                                                                               ");
            }            
        }
    }
}

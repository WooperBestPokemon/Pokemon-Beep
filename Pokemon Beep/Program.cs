using Pokemon_Beep.Battle;
using Pokemon_Beep.Factory;
using Pokemon_Beep.Other;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Pokemon_Beep
{
    class Program
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        static void Main(string[] args)
        {
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_MINIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
            }
            Testing testing = new Testing();
            //testing.statsTest();
            //testing.evolutionTest();
            //testing.asciiTest();
            testing.asciiTest();
            /*
            Game game = new Game();
            World world = new World();
            game.init();           
            world.init();
            world.printMap(0);
            //Console.ReadKey();


            ConsoleKeyInfo keyinfo;
            bool movement= true;
            int posX = 14;
            int posY = 13;
            int oldX = posX;
            int oldY = posY;
            while (movement == true)
            {
                keyinfo = Console.ReadKey(true);
                if (keyinfo.Key == ConsoleKey.S)
                {
                    oldY = posY;
                    oldX = posX;
                    posY++;
                }
                else if (keyinfo.Key == ConsoleKey.A)
                {
                    oldY = posY;
                    oldX = posX;
                    posX--;
                }
                else if (keyinfo.Key == ConsoleKey.W)
                {
                    oldY = posY;
                    oldX = posX;
                    posY--;
                }
                else if (keyinfo.Key == ConsoleKey.D)
                {
                    oldY = posY;
                    oldX = posX;
                    posX++;
                }
                else
                    movement = false;
                if(world.hit(posX,posY))
                {
                    posX = oldX;
                    posY = oldY;
                }                    
                else
                    printPlayer();
            }
            void printPlayer()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(posX, posY);
                Console.Write('O');
                Console.SetCursorPosition(oldX, oldY);                
                Console.Write(' ');
                world.printOldCharacter(oldX, oldY);
            }
            */
        }

    }
}

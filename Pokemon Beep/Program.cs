using System;

namespace Pokemon_Beep
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

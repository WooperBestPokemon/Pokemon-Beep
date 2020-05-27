﻿using Pokemon_Beep.Battle;
using Pokemon_Beep.Factory;
using System;
using System.Collections.Generic;

namespace Pokemon_Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveFactory moveFactory = new MoveFactory();
            List<Move> moves;
            moves = moveFactory.GetMoves();
            bool miss = false;
            
            while (true)
            {
                int choice;
                Console.WriteLine("What do you want to do ?");
                Console.WriteLine("1. " + moves[0]);
                Console.WriteLine("2. " + moves[1]);
                choice = Convert.ToInt32(Console.ReadLine());
                while (!(miss))
                {
                    if (moves[choice - 1].Hit())
                    {
                        Console.WriteLine("The move hit!");
                        if (moves[choice - 1].EffectHit())
                            Console.WriteLine(moves[choice - 1].Effect.ToString());
                    }
                    else
                        miss = true;
                }
                Console.ReadKey();
            }
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
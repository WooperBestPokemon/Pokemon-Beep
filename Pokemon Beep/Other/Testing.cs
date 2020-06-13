using Pokemon_Beep.Battle;
using Pokemon_Beep.Factory;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Other
{
    class Testing
    {
        private enum type
        {
            Normal = 1,
            Fire = 2,
            Water = 3,
            Electric = 4,
            Grass = 5,
            Ice = 6,
            Fighting = 7,
            Poison = 8,
            Ground = 9,
            Fly = 10,
            Psy = 11,
            Bug = 12,
            Rock = 13,
            Ghost = 14,
            Dragon = 15,
            Dark = 16,
            Steel = 17,
            Fairy = 18
        }
        public void effectivenessTest()
        {
            Ability ability = new Ability(1, "test");
            List<Ability> test = new List<Ability>();
            List<char> sexe = new List<char>();
            List<int> typePkm = new List<int>();
            typePkm.Add((int)type.Normal);
            typePkm.Add((int)type.Fire);
            typePkm.Add((int)type.Water);
            typePkm.Add((int)type.Electric);
            typePkm.Add((int)type.Ice);
            typePkm.Add((int)type.Fighting);
            typePkm.Add((int)type.Poison);
            typePkm.Add((int)type.Ground);
            typePkm.Add((int)type.Fly);
            typePkm.Add((int)type.Psy);
            typePkm.Add((int)type.Bug);
            typePkm.Add((int)type.Rock);
            typePkm.Add((int)type.Ghost);
            typePkm.Add((int)type.Dragon);
            typePkm.Add((int)type.Dark);
            typePkm.Add((int)type.Grass);
            typePkm.Add((int)type.Steel);
            typePkm.Add((int)type.Fairy);
            sexe.Add('M');
            test.Add(ability);
            PocketMonster pocketMonster = new PocketMonster(000, "Ditto", "1", "1", test, sexe, typePkm, 1000000);
            TypeChart chart = new TypeChart();
            Console.WriteLine("Normal x" + chart.effectivity((int)type.Normal, pocketMonster));
            Console.WriteLine("Fire x" + chart.effectivity((int)type.Fire, pocketMonster));
            Console.WriteLine("Water x" + chart.effectivity((int)type.Water, pocketMonster));
            Console.WriteLine("Electric x" + chart.effectivity((int)type.Electric, pocketMonster));
            Console.WriteLine("Grass x" + chart.effectivity((int)type.Grass, pocketMonster));
            Console.WriteLine("Ice x" + chart.effectivity((int)type.Ice, pocketMonster));
            Console.WriteLine("Fighting x" + chart.effectivity((int)type.Fighting, pocketMonster));
            Console.WriteLine("Poison x" + chart.effectivity((int)type.Poison, pocketMonster));
            Console.WriteLine("Ground x" + chart.effectivity((int)type.Ground, pocketMonster));
            Console.WriteLine("Fly x" + chart.effectivity((int)type.Fly, pocketMonster));
            Console.WriteLine("Psy x" + chart.effectivity((int)type.Psy, pocketMonster));
            Console.WriteLine("Bug x" + chart.effectivity((int)type.Bug, pocketMonster));
            Console.WriteLine("Rock x" + chart.effectivity((int)type.Rock, pocketMonster));
            Console.WriteLine("Ghost x" + chart.effectivity((int)type.Ghost, pocketMonster));
            Console.WriteLine("Dragon x" + chart.effectivity((int)type.Dragon, pocketMonster));
            Console.WriteLine("Dark x" + chart.effectivity((int)type.Dark, pocketMonster));
            Console.WriteLine("Steel x" + chart.effectivity((int)type.Steel, pocketMonster));
            Console.WriteLine("Fairy x" + chart.effectivity((int)type.Fairy, pocketMonster));
            Console.ReadKey();
        }
        public void moveTest()
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

                        else
                            miss = true;
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}

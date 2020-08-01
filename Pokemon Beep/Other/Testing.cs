﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Pokemon_Beep.Combat;
using Pokemon_Beep.Factory;
using Pokemon_Beep.Graphic;
using Pokemon_Beep.Pokemon;

namespace Pokemon_Beep.Other
{
    class Testing
    {
        /// <summary>
        /// This class is used for testing. Will be removed when the game is done.
        /// </summary>
        public void statsTest()
        {
            //Init Pokemons
            PokemonFactory factory = new PokemonFactory();
            //Get Attacker and Defender
            PocketMonster attacker = factory.Pachirisu();
            PocketMonster defender = factory.Pachirisu();
            attacker.generateWildPokemon(24);
            defender.generateWildPokemon(50);
            Console.WriteLine(attacker);
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine(defender);
            Console.ReadKey();
        }
        public void evolutionTest()
        {
            PokemonFactory factory = new PokemonFactory();
            PocketMonster testPokemon = factory.Rattata();
            testPokemon.generateWildPokemon(1);
            while (true)
            {
                Console.WriteLine(testPokemon);            
                Console.ReadKey();
                testPokemon.levelUp();
                Console.Clear();
            }
        }
        public void damageTest()
        {
            DamageCalculator damageCalculator = new DamageCalculator();
            BattleStatus battleStatus = new BattleStatus();
            PokemonFactory factory = new PokemonFactory();
            PocketMonster attacker = factory.Rattata();
            PocketMonster defender = factory.Pachirisu();
            attacker.generateWildPokemon(50);
            defender.generateWildPokemon(100);
            defender.currentHP = defender.HP;
            Console.Write(attacker);
            Console.Write(defender);
            Console.ReadKey();
            Console.Clear();
            attacker.resetStage();
            while (true)
            {
                Console.WriteLine("Attacker : " + attacker.Name);
                Console.WriteLine("Defender : " + defender.Name + "\n");

                Console.WriteLine("============================" + "\n" +
                    "Attacker" + "\n" +
                    "============================");
                Console.WriteLine("Attack : " + attacker.Attack);
                Console.WriteLine("Special Attack : " + attacker.SpecialAttack + "\n");
                Console.WriteLine("============================" + "\n" +
                    "Defender" + "\n" +
                    "============================");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HP : " + defender.currentHP + "/" + defender.HP);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Defense : " + defender.Defense);
                Console.WriteLine("Special Defense : " + defender.SpecialDefense + "\n");

                Console.WriteLine("");
                Console.WriteLine("Choose a move");
                for (int i = 0; i < attacker.Moveset.Count; i++)
                {
                    Console.WriteLine(i + ". " + attacker.Moveset[i].Name);
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                int damage = damageCalculator.getDamage(attacker, defender, attacker.Moveset[choice], battleStatus);
                Console.WriteLine("The wild " + defender.Name + "lost " + damage + " HP !");
                defender.currentHP -= damage;
                Console.ReadKey();
                Console.Clear();
            }            
        }
        public void battleTest()
        {
            PokemonFactory factory = new PokemonFactory();
            PocketMonster defender = factory.Furret();
            defender.generateWildPokemon(50);
            defender.currentHP = defender.HP;
            PkmnBattleInfo pkmnA = new PkmnBattleInfo(defender);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HP : " + pkmnA.Pokemon.currentHP + "/" + pkmnA.Pokemon.HP);
            Console.ReadKey();
            Console.Clear();
            pkmnA.Pokemon.currentHP -= 10;
            Console.WriteLine("HP : " + defender.currentHP + "/" + defender.HP);
            Console.ReadKey();

            //Conclusion : pkmnA can modify the Pokemon (Defender)

        }
        public void graphic()
        {
            Console.CursorVisible = false;
            /*
            int oldPosX = 0;
            int posY = 4;
            for (int i = 1; i < 121; i++)
            {
                Console.SetCursorPosition(i, posY);
                Console.Write("O");
                Console.SetCursorPosition(oldPosX, posY);
                Console.Write(" ");
                oldPosX++;
                System.Threading.Thread.Sleep(5);
            }
            */
            int posX = 50;
            int posY = 10;
            
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("@");
            }
        }
        public void proprietyTest()
        {
            PokemonFactory factory = new PokemonFactory();
            MoveFactory moveFactory = new MoveFactory();
            List<Move> moves = moveFactory.GetMoves();

            Battle battle = new Battle();

            PocketMonster pachirisu = factory.Pachirisu();
            pachirisu.generateWildPokemon(5);

            PocketMonster sentret = factory.Sentret();
            sentret.generateWildPokemon(5);

            PkmnBattleInfo pokemonA = new PkmnBattleInfo(sentret);
            PkmnBattleInfo pokemonB = new PkmnBattleInfo(pachirisu);

            Console.WriteLine(pachirisu);
            Console.WriteLine("========================================================================");
            Console.WriteLine(sentret);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Test 1 : Sentret is slower than pachirisu, but use Quick Attack");
            Console.ForegroundColor = ConsoleColor.White;
            if (battle.playerAttackFirst(pokemonA, pokemonB, moves[(int) Enum.move.Quick_Attack], moves[(int)Enum.move.Tackle]))
            {
                Console.WriteLine("The " + pokemonA.Pokemon.Name + " Attack First");
            }
            else
            {
                Console.WriteLine("The " + pokemonB.Pokemon.Name + " Attack First");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Test 2 : Sentret is slower than pachirisu, they both use the same move");
            Console.ForegroundColor = ConsoleColor.White;
            if (battle.playerAttackFirst(pokemonA, pokemonB, moves[(int)Enum.move.Tackle], moves[(int)Enum.move.Tackle]))
            {
                Console.WriteLine("The " + pokemonA.Pokemon.Name + " Attack First");
            }
            else
            {
                Console.WriteLine("The " + pokemonB.Pokemon.Name + " Attack First");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Test 3 : Sentret is slower than pachirisu, they both use the same move with a proprity");
            Console.ForegroundColor = ConsoleColor.White;
            if (battle.playerAttackFirst(pokemonA, pokemonB, moves[(int)Enum.move.Quick_Attack], moves[(int)Enum.move.Quick_Attack]))
            {
                Console.WriteLine("The " + pokemonA.Pokemon.Name + " Attack First");
            }
            else
            {
                Console.WriteLine("The " + pokemonB.Pokemon.Name + " Attack First");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Test 4 : Sentret use protect, but pachirisu use Quick Attack.");
            Console.ForegroundColor = ConsoleColor.White;
            if (battle.playerAttackFirst(pokemonA, pokemonB, moves[(int)Enum.move.Protect], moves[(int)Enum.move.Quick_Attack]))
            {
                Console.WriteLine("The " + pokemonA.Pokemon.Name + " Attack First");
            }
            else
            {
                Console.WriteLine("The " + pokemonB.Pokemon.Name + " Attack First");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Test 5 : Sentret is slower, but his speed stage is maxed !");
            Console.ForegroundColor = ConsoleColor.White;
            pokemonA.Pokemon.stages[(int)Enum.stat.Speed] = 6;
            if (battle.playerAttackFirst(pokemonA, pokemonB, moves[(int)Enum.move.Protect], moves[(int)Enum.move.Quick_Attack]))
            {
                Console.WriteLine("The " + pokemonA.Pokemon.Name + " Attack First");
            }
            else
            {
                Console.WriteLine("The " + pokemonB.Pokemon.Name + " Attack First");
            }
        }
        public void asciiTest()
        {
            Animation animation = new Animation();
            Console.SetWindowSize(83, 30);
            Console.SetBufferSize(83, 30);
            Console.CursorVisible = false;
            Utilities.changeBackgroundColor(47, 53, 32);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                               ╔══════════╗    ║");
            Console.WriteLine(" ║                                                               ║Pokédex < ║    ║");
            Console.WriteLine(" ║                                                               ║Pokémon   ║    ║");
            Console.WriteLine(" ║                                                               ║Bag       ║    ║");
            Console.WriteLine(" ║                                                               ║PlayerName║    ║");
            Console.WriteLine(" ║                                                               ║Save      ║    ║");
            Console.WriteLine(" ║                                                               ║Option    ║    ║");
            Console.WriteLine(" ║                                                               ║Exit      ║    ║");
            Console.WriteLine(" ║                                                               ║          ║    ║");
            Console.WriteLine(" ║                                                               ╚══════════╝    ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                               ║");
            Console.WriteLine(" ║                                                                ╔════╗         ║");
            Console.WriteLine(" ║                                                                ║Yes<║         ║");
            Console.WriteLine(" ║                                                                ║No< ║         ║");
            Console.WriteLine(" ║                                                                ╚════╝         ║");
            Console.WriteLine(" ║    ╔═════════════════════════════════════════════════════════════════════╗    ║");
            Console.WriteLine(" ║    ║ Hi ! Welcome to the Poké-center. Would you like me to heal your     ║    ║");
            Console.WriteLine(" ║    ║ Pokémon ?                                                           ║    ║");
            Console.WriteLine(" ║    ╚═════════════════════════════════════════════════════════════════════╝    ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(41, 14);
            Utilities.changeForegroundColor(255, 163, 255);
            Console.WriteLine("+");
            Console.ReadKey();
            animation.wildPokemonBattleAnimation();
            Console.ReadKey();
        }
        public void asciiPokemon()
        {
            Console.SetWindowSize(83, 30);
            Console.SetBufferSize(83, 30);
            Console.CursorVisible = false;
            /*
            Utilities.changeForegroundColor(196, 144, 93);
            Console.WriteLine(";-.               ,");
            Console.WriteLine(" \\ '.           .'/");
            Console.WriteLine("  \\  \\ .---. .-' /");
            Console.WriteLine("   '. '     `\\_.'");
            Console.WriteLine("     | O  O  |     ,");
            Console.WriteLine("     (  u    /   .' \\");
            Console.WriteLine("\x1b[38;2;240;219;179m" + "    .''.___.'--," + "\x1b[38;2;196;144;93m" + "/\\_,|");
            Console.WriteLine("\x1b[38;2;240;219;179m" + "   {  /     \\   }" + "\x1b[38;2;196;144;93m" + "   |");
            Console.WriteLine("\x1b[38;2;240;219;179m" + "    '.\\     /_.'" + "\x1b[38;2;196;144;93m" + "    / ");
            Console.WriteLine("     |" + "\x1b[38;2;240;219;179m" + "'-.-'" + "\x1b[38;2;196;144;93m" + ",  `; _.'");
            Console.WriteLine("     |  |  |   |`");
            Console.WriteLine("     `\"\"`\"\"`\"\"\"`");
            Console.ReadKey();
            Console.Clear();
            */

            Utilities.changeForegroundColor(0, 0, 0);
            Utilities.changeBackgroundColor(47, 53, 32);
            Console.Clear();
            Console.WriteLine("                            ██████");
            Console.WriteLine("                          ██" + "\x1b[38;2;204;153;254m" + "████" + "\x1b[38;2;0;0;0m" + "████");
            Console.WriteLine("                        ██" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;0;0;0m" + "████" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("                        ██" + "\x1b[38;2;204;153;254m" + "████" + "\x1b[38;2;0;0;0m" + "██" +  "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("                          ████" + "\x1b[38;2;153;51;255m" + "████" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("                            ██" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("          ██        ████████" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("        ██" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;0;0;0m" + "██  ████" + "\x1b[38;2;204;153;254m" + "████████" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("        ██" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;0;0;0m" + "████" + "\x1b[38;2;153;51;255m" + "████" + "\x1b[38;2;0;0;0m" + "████" + "\x1b[38;2;204;153;254m" + "██████" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("      ██" + "\x1b[38;2;204;153;254m" + "████████" + "\x1b[38;2;0;0;0m" + "████" + "\x1b[38;2;204;153;254m" + "████" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;153;51;255m" + "████" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("    ██" + "\x1b[38;2;204;153;254m" + "████████████" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;255;181;72m" + "██" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;153;51;255m" + "██████" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("  ████" + "\x1b[38;2;204;153;254m" + "██████████████" + "\x1b[38;2;255;181;72m" + "██" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("██" + "\x1b[38;2;217;217;217m" + "██" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;204;153;254m" + "████████" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;153;51;255m" + "████████" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;153;51;255m" + "████" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("  ██" + "\x1b[38;2;255;255;255m" + "██" + "\x1b[38;2;204;153;254m" + "██████" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;255;255;255m" + "██" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;153;51;255m" + "████" + "\x1b[38;2;0;0;0m" + "████" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("  ██" + "\x1b[38;2;255;255;255m" + "██████" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;254;0;0m" + "██" + "\x1b[38;2;255;255;255m" + "██████" + "\x1b[38;2;0;0;0m" + "██" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "████" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("    ██" + "\x1b[38;2;217;217;217m" + "██" + "\x1b[38;2;255;255;255m" + "██████" + "\x1b[38;2;0;0;0m" + "██████" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "████████");
            Console.WriteLine("    ██" + "\x1b[38;2;255;255;255m" + "██" + "\x1b[38;2;0;0;0m" + "██████████" + "\x1b[38;2;153;51;255m" + "████" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("      ██  ██" + "\x1b[38;2;217;217;217m" + "██" + "\x1b[38;2;0;0;0m" + "████" + "\x1b[38;2;204;153;254m" + "██" + "\x1b[38;2;153;51;255m" + "██" + "\x1b[38;2;0;0;0m" + "██");
            Console.WriteLine("            ████" + "\x1b[38;2;255;255;255m" + "████" + "\x1b[38;2;0;0;0m" + "███");
            Console.WriteLine("                ████");
        }
        public void mapTesting()
        {
            World world = new World();
            world.init();
            world.printMap(0);
            Console.ReadKey();
        }
        public void scriptTest()
        {            
            Console.SetWindowSize(83, 30);
            Console.SetBufferSize(83, 30);
            Utilities.changeBackgroundColor(50, 50, 50);
            Console.Clear();
            Console.WriteLine("                                  \x1b[38;2;0;0;0m██");
            Console.WriteLine("                                \x1b[38;2;0;0;0m██\x1b[38;2;255;255;115m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("                                \x1b[38;2;0;0;0m██\x1b[38;2;255;255;115m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("                              \x1b[38;2;0;0;0m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("                  \x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██      \x1b[38;2;0;0;0m██\x1b[38;2;213;189;41m██\x1b[38;2;213;189;41m██\x1b[38;2;255;255;115m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("                \x1b[38;2;0;0;0m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;0;0;0m██  \x1b[38;2;0;0;0m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;213;189;41m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("                \x1b[38;2;0;0;0m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;82;82;82m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;82;82;82m██\x1b[38;2;255;255;115m██\x1b[38;2;213;189;41m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("          \x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;180;180;197m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;255;255;115m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;82;82;82m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("      \x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;255;186;218m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;82;82;82m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;255;238;189m██\x1b[38;2;255;238;189m██\x1b[38;2;255;186;218m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("    \x1b[38;2;0;0;0m██\x1b[38;2;255;238;189m██\x1b[38;2;255;148;197m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;255;238;189m██\x1b[38;2;255;238;189m██\x1b[38;2;255;238;189m██\x1b[38;2;82;82;82m██\x1b[38;2;82;82;82m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("  \x1b[38;2;0;0;0m██\x1b[38;2;255;238;189m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;255;255;115m██\x1b[38;2;82;82;82m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("  \x1b[38;2;0;0;0m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;213;189;41m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;180;180;197m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("  \x1b[38;2;0;0;0m██\x1b[38;2;213;189;41m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;255;115m██\x1b[38;2;255;186;218m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;82;82;82m██\x1b[38;2;255;255;255m██\x1b[38;2;255;255;255m██\x1b[38;2;180;180;197m██\x1b[38;2;180;180;197m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("  \x1b[38;2;0;0;0m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;255;255;115m██\x1b[38;2;255;186;218m██\x1b[38;2;82;82;82m██\x1b[38;2;255;238;189m██\x1b[38;2;255;238;189m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;82;82;82m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("\x1b[38;2;0;0;0m██\x1b[38;2;255;148;197m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;255;186;218m██\x1b[38;2;255;238;189m██\x1b[38;2;82;82;82m██\x1b[38;2;255;238;189m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;82;82;82m██\x1b[38;2;213;189;41m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;213;90;139m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;255;148;197m██\x1b[38;2;255;238;189m██\x1b[38;2;255;238;189m██\x1b[38;2;82;82;82m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("      \x1b[38;2;0;0;0m██\x1b[38;2;213;90;139m██\x1b[38;2;82;82;82m██\x1b[38;2;213;189;41m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;255;148;197m██\x1b[38;2;213;189;41m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("        \x1b[38;2;0;0;0m██\x1b[38;2;255;148;197m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██");
            Console.WriteLine("        \x1b[38;2;0;0;0m██\x1b[38;2;0;0;0m██");











        }
    }
}

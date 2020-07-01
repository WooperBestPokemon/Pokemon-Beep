using Pokemon_Beep.Battle;
using Pokemon_Beep.Factory;
using Pokemon_Beep.Player;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

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
            BattleStatus battleStatus = new BattleStatus();
            DamageCalculator damageCalculator = new DamageCalculator();
            PokemonFactory factory = new PokemonFactory();
            PocketMonster attacker = factory.Rattata();
            PocketMonster defender = factory.Pachirisu();
            attacker.generateWildPokemon(50);
            defender.generateWildPokemon(50);
            defender.currentHP = defender.HP;
            Console.Write(attacker);
            Console.Write(defender);
            Console.ReadKey();
            Console.Clear();

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
    }
}

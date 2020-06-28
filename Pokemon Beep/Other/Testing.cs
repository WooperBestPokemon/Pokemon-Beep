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
        public void damageTest()
        {
            //Init Pokemons
            Pokedex pokedex = new Pokedex();
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
    }
}

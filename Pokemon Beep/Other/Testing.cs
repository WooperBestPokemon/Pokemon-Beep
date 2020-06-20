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
        public void damageTest()
        {
            //Init Pokemons
            Pokedex pokedex = new Pokedex();
            //Get Attacker and Defender
            PocketMonster attacker = pokedex.getPokemon(0);
            attacker.generateWildPokemon(16);
            Console.WriteLine(attacker);
            Console.WriteLine("______________________________________________________________________________");
            Console.ReadKey();
        }
    }
}

using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class PokemonFactory
    {
        public List<PocketMonster> GetPokemons()
        {
            List<PocketMonster> pokemons = new List<PocketMonster>();
            //pokemons.Add(new PocketMonster(56,"Wooper","0.4", "8.5"))
            return pokemons;
        }
    }
}

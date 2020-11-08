using Pokemon_Beep.Factory;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    static class Pokedex
    {
        /// <summary>
        /// This class is where all the Pokémons informations are. Its only purpose is to return a Pokemon information.
        /// </summary>
        private static PokemonFactory factory = new PokemonFactory();
        public static PokemonInfo getInfo(int pokedexID)
        {
            return factory.getPokemon(pokedexID);
        }
    }
}

using Pokemon_Beep.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Pokemon
{
    class Pokedex
    {
        /// <summary>
        /// This class is where all the Pokémons informations are. Its only purpose is to return a Pokemon.
        /// </summary>
        private List<PocketMonster> pokemons = new List<PocketMonster>();
        private PokemonFactory factory = new PokemonFactory();
        public Pokedex()
        {
            pokemons = factory.GetPokemons();
        }
        public PocketMonster getPokemon(int pokedexID)
        {
            return pokemons[pokedexID];
        }

    }
}

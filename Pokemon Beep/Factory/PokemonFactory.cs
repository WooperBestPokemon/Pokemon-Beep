using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class PokemonFactory
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
        public List<PocketMonster> GetPokemons()
        {
            List<PocketMonster> pokemons = new List<PocketMonster>();
            //Wooper
            List<int> typeWooper = new List<int>();
            typeWooper.Add((int)type.Water);
            typeWooper.Add((int)type.Ground);
            //pokemons.Add(new PocketMonster(001,"Wooper", "uwu", "uwu",))
            return pokemons;
        }
    }
}

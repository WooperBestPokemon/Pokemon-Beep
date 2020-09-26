using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.AI
{
    class WildPokemonAI
    {
        private PocketMonster pokemon;
        public WildPokemonAI(PocketMonster pokemon)
        {
            this.pokemon = pokemon;
        }
        public int getChoice()
        {
            int choice = Utilities.RandomNumber(1, pokemon.Moveset.Count);
            return choice;
        }
    }
}

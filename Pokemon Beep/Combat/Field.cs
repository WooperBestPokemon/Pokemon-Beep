using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Combat
{
    class Field
    {
        public Field(PkmnBattleInfo pokemonInfo)
        {
            PokemonInfo = pokemonInfo;
        }
        public int Spike { get; set; }
        public int LightScreen { get; set; }
        public int Reflect { get; set; }
        public bool StealthRock { get; set; }
        public PkmnBattleInfo PokemonInfo { get; set; }
    }
}

using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class PkmnBattleInfo
    {
        public PkmnBattleInfo(PocketMonster pokemon)
        {
            Pokemon = pokemon;
        }
        public PocketMonster Pokemon { get; }
    }
}

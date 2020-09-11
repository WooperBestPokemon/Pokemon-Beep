using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Combat
{
    class PkmnBattleInfo
    {
        public PkmnBattleInfo(PocketMonster pokemon)
        {
            Pokemon = pokemon;
        }
        public PocketMonster Pokemon { get; }
        public bool[] secondaryStatus = new bool[11];
    }
}

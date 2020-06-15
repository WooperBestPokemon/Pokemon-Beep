using Pokemon_Beep.Battle;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Pokemon_Beep.Pokemon
{
    class Learnset
    {
        public Learnset(Move pkmMove, int level)
        {
            Level = level;
            PkmMove = pkmMove;
        }
        public Move PkmMove { get; }
        public int Level { get; }
    }
}

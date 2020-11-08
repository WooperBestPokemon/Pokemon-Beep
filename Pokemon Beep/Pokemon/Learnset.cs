﻿using Pokemon_Beep.Combat;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Pokemon_Beep.Pokemon
{
    [Serializable]
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

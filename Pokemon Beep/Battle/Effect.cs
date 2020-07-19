using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class Effect
    {
        public Effect(int id)
        {
            ID = id;
            Multiplicator = 1;
        }
        public Effect(int id, int multiplicator)
        {
            ID = id;
            Multiplicator = multiplicator;
        }
        public int ID { get; }
        public int Multiplicator { get; }
    }
}

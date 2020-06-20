using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class Effect
    {
        private Random rand = new Random();
        public Effect(int id, int multiplicator)
        {
            ID = id;
            Multiplicator = multiplicator;
            Chance = 100;
        }
        public Effect(int id, int multiplicator, int chance)
        {
            ID = id;
            Multiplicator = multiplicator;
            Chance = chance;
        }
        public Effect(int id)
        {
            ID = id;
            Chance = 100;
            Multiplicator = 1;
        }
        public int ID { get; }
        public int Chance { get; }
        public int Multiplicator { get; }
        public override string ToString()
        {
            string description = Chance + " % ";
            return description;
        }
    }
}

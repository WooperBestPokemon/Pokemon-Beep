using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Combat
{
    class Effect
    {
        public Effect(int id)
        {
            ID = id;
            Multiplicator = 1;
        }
        public Effect(int id, bool self)
        {
            ID = id;
            Multiplicator = 1;
            Self = self;
        }
        public Effect(int id, int multiplicator)
        {
            ID = id;
            Multiplicator = multiplicator;
            Self = false;
        }
        public Effect(int id, int multiplicator, bool self)
        {
            ID = id;
            Multiplicator = multiplicator;
            Self = self;
        }
        public int ID { get; }
        public int Multiplicator { get; }
        public bool Self { get; }
    }
}

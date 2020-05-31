using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class Effect
    {
        private Random rand = new Random();
        public Effect(int id, string name, int multiplicator)
        {
            ID = id;
            Name = name;
            Chance = 100;
            Multiplicator = multiplicator;
        }
        public Effect(int id, string name, int chance, int multiplicator)
        {
            ID = id;
            Name = name;
            Chance = chance;
            Multiplicator = multiplicator;
        }
        public Effect(int id, string name)
        {
            ID = id;
            Name = name;
            Chance = 100;
            Multiplicator = 1;
        }
        public int ID { get; }
        public string Name { get; }
        public int Chance { get; }
        public int Multiplicator { get; }
        public override string ToString()
        {
            string description = Chance + " % ";
            switch(ID)
            {
                case 0:
                    description += "No special effect";
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    description += "Lower Target Speed by 1 stage";
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
            return description;
        }
    }
}

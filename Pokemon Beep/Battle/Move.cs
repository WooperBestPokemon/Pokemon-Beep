using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class Move
    {
        private Random rand = new Random();
        public Move(string name, int power, int accuracy, int pp, int type, Effect effect, string category)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = category;
        }
        public Move(string name, int accuracy, int pp, int type, Effect effect)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = "Special";
        }
        public string Name { get; }
        public int Power { get; }
        public int Accuracy { get; }
        public int PP { get; }
        public int Type { get; }
        public Effect Effect { get; }
        public string Category { get; }
        public bool Hit()
        {
            if (rand.Next(1, 101) <= Accuracy)
                return true;
            else
                return false;
        }
        public bool EffectHit()
        {
            if (rand.Next(1, 101) <= Effect.Chance)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return Name + " : " + Category + " attack with " + Power + " power and " + Accuracy + " % chance of hit ! " + Effect.ToString();
        }
    }
}

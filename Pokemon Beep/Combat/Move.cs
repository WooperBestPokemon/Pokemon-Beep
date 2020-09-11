using System;
using System.Collections.Generic;

namespace Pokemon_Beep.Combat
{
    partial class Move
    {
        public Move(string name, int power, int accuracy, int pp, int type, Delegate effect, string category, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = category;
            Priority = 0;
            Description = description;
        }
        public Move(string name, int power, int accuracy, int pp, int type, Delegate effect, string category, int priority, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = category;
            Priority = priority;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, Delegate effect, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = "Status";
            Priority = 0;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, Delegate effect, int priority, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = "Status";
            Priority = priority;
            Description = description;
        }

        public Move(string name, int power, int pp, int type, Delegate effect, string category, string description)
        {
            Name = name;
            Power = power;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = category;
            Priority = 0;
            Description = description;
            CanMiss = false;
        }
        public Move(string name, int power,  int pp, int type, Delegate effect, string category, int priority, string description)
        {
            Name = name;
            Power = power;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = category;
            Priority = priority;
            Description = description;
            CanMiss = false;
        }
        public Move(string name, int pp, int type, Delegate effect, string description)
        {
            Name = name;
            Power = 0;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = "Status";
            Priority = 0;
            Description = description;
            CanMiss = false;
        }
        public Move(string name, int pp, int type, Delegate effect, int priority, string description)
        {
            Name = name;
            Power = 0;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = "Status";
            Priority = priority;
            Description = description;
            CanMiss = false;
        }

        public Move(string name, int power, int accuracy, int pp, int type, Delegate effect, string category, string description, bool highCrit)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effect = effect;
            Category = category;
            Priority = 0;
            Description = description;
            HighCrit = highCrit;
        }

        public string Name { get; }
        public int Power { get; }
        public int Accuracy { get; } = 0;
        public int PP { get; }
        public int Type { get; }
        public Delegate Effect { get; }
        public string Category { get; }
        public int Priority { get; }
        public string Description { get; }
        public bool CanMiss { get; } = true;
        public bool HighCrit { get; } = false;
        public override string ToString()
        {
            return Name + " : " + Category + " attack with " + Power + " power and " + Accuracy + " % chance of hit !";
        }
    }
}

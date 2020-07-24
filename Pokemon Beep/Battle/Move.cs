using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class Move
    {
        public Move(string name, int power, int accuracy, int pp, int type, Effect effect, int effectChance, string category, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            Effects.Add(effect);
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = category;
            Priority = 0;
            Description = description;
        }
        public Move(string name, int power, int accuracy, int pp, int type, Effect effect, int effectChance, string category, int priority, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            Effects.Add(effect);
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = category;
            Priority = priority;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, Effect effect, int effectChance, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            Effects.Add(effect);
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = "Status";
            Priority = 0;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, Effect effect, int effectChance, int priority, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            Effects.Add(effect);
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = "Status";
            Priority = priority;
            Description = description;
        }

        public Move(string name, int power, int accuracy, int pp, int type, List<Effect> effects, int effectChance, string category, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = category;
            Priority = 0;
            Description = description;
        }
        public Move(string name, int power, int accuracy, int pp, int type, List<Effect> effects, int effectChance, string category, int priority, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = category;
            Priority = priority;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, List<Effect> effects, int effectChance, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = "Status";
            Priority = 0;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, List<Effect> effects, int effectChance, int priority, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = new List<int>();
            EffectsChance.Add(effectChance);
            Category = "Status";
            Priority = priority;
            Description = description;
        }

        public Move(string name, int power, int accuracy, int pp, int type, List<Effect> effects, List<int> effectChance, string category, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = effectChance;
            Category = category;
            Priority = 0;
            Description = description;
        }
        public Move(string name, int power, int accuracy, int pp, int type, List<Effect> effects, List<int> effectChance, string category, int priority, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = effectChance;
            Category = category;
            Priority = priority;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, List<Effect> effects, List<int> effectChance, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = effectChance;
            Category = "Status";
            Priority = 0;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type, List<Effect> effects, List<int> effectChance, int priority, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = effects;
            EffectsChance = effectChance;
            Category = "Status";
            Priority = priority;
            Description = description;
        }
        public string Name { get; }
        public int Power { get; }
        public int Accuracy { get; }
        public int PP { get; }
        public int Type { get; }
        public List<Effect> Effects { get; }
        public List<int> EffectsChance { get; }
        public string Category { get; }
        public int Priority { get; }
        public string Description { get; }

        public override string ToString()
        {
            return Name + " : " + Category + " attack with " + Power + " power and " + Accuracy + " % chance of hit ! ";
        }
    }
}

using System;
using System.Collections.Generic;

namespace Pokemon_Beep.Combat
{
    class Move
    {
        public Move(string name, int power, int accuracy, int pp, int type, string category, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            EffectsChance = new List<int>();
            Category = category;
            Priority = 0;
            Description = description;
        }
        public Move(string name, int power, int accuracy, int pp, int type, string category, int priority, string description)
        {
            Name = name;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            EffectsChance = new List<int>();
            Category = category;
            Priority = priority;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type,  string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            EffectsChance = new List<int>();
            Category = "Status";
            Priority = 0;
            Description = description;
        }
        public Move(string name, int accuracy, int pp, int type,  int priority, string description)
        {
            Name = name;
            Power = 0;
            Accuracy = accuracy;
            PP = pp;
            Type = type;
            Effects = new List<Effect>();
            EffectsChance = new List<int>();
            Category = "Status";
            Priority = priority;
            Description = description;
        }

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
        public void doEffect(PkmnBattleInfo player, PkmnBattleInfo foe)
        {
            //If the move has an effect
            if(Effects.Count != 0)
            {
                for (int i = 0; i < Effects.Count; i++)
                {
                    //Status
                    if(Effects[i].ID == (int)Enum.effect.burn)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if(EffectsChance.Count > 1)
                        {
                            if (EffectsChance[i] >= random)
                                foe.Pokemon.Status = (int)Enum.status.Burned;
                        }
                        else
                        {
                            if (EffectsChance[0] >= random)
                                foe.Pokemon.Status = (int)Enum.status.Burned;
                        }
                        //TODO "The FoePokemonName was burned"
                    }
                    if (Effects[i].ID == (int)Enum.effect.sleep)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (EffectsChance.Count > 1)
                        {
                            if (EffectsChance[i] >= random)
                                foe.Pokemon.Status = (int)Enum.status.Sleep;
                        }
                        else
                        {
                            if (EffectsChance[0] >= random)
                                foe.Pokemon.Status = (int)Enum.status.Sleep;
                        }
                        //TODO "The FoePokemonName is asleep"
                    }
                }
            }
        }

        public override string ToString()
        {
            string description = Name + " : " + Category + " attack with " + Power + " power and " + Accuracy + " % chance of hit ! \n";
            for (int i = 0; i < Effects.Count; i++)
            {
                description += "Effect : " + Effects[i].ID + " by " + Effects[i].Multiplicator + " times and has a " + EffectsChance[i] + " % of success";
            }
            return description;
        }
    }
}

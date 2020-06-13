using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class Ability
    {
        public Ability(string name, string description, int effect)
        {
            Name = name;
            Description = description;
            Effect = effect;
        }
        public string Name { get; }
        public string Description { get; }
        public int Effect { get; }

    }
}

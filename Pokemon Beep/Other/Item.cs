using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Other
{
    [Serializable]
    class Item
    {
        public Item(string name, string description, int categorie, Delegate effect)
        {
            Name = name;
            Description = description;
            Categorie = categorie;
            Effect = effect;
        }
        public string Name { get; }
        public string Description { get; }
        public int Categorie { get; }
        public Delegate Effect { get; }
    }
}

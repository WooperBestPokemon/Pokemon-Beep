using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Other
{
    [Serializable]
    class Item
    {
        public Item(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
    }
}

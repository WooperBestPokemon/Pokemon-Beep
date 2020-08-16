using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Other
{
    class Item
    {
        public Item(int id, string description)
        {
            Id = id;
            Description = description;
        }
        public int Id { get; }
        public string Description { get; }
    }
}

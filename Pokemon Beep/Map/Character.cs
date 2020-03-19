using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Character
    {
        public Character(char charact, string color)
        {
            Charact = charact;
            Color = color;
        }
        public char Charact { get; set; }
        public string Color { get; set; }
    }
}

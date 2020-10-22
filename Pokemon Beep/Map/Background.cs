using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Background
    {
        public Background(char[,] characters, string[,] colors)
        {
            Characters = characters;
            Colors = colors;
        }
        public char[,] Characters { get; set; }
        public string[,] Colors { get; set; }
    }
}

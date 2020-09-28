using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Combat
{
    class BattleField
    {
        public BattleField(Field player, Field foe)
        {
            PlayerField = player;
            FoeField = foe;
        }
        public Field PlayerField { get; set; }
        public Field FoeField { get; set; }
        public int Weather { get; set; }
    }
}

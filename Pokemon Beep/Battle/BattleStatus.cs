using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class BattleStatus
    {
        private double getMultiplicator(int stage)
        {
            if (stage == 0)
                return 1;
            else if (stage == 1)
                return 1.5;
            else if (stage == 2)
                return 2;
            else if (stage == 3)
                return 2.5;
            else if (stage == 4)
                return 3;
            else if (stage == 5)
                return 3.5;
            else if (stage == 6)
                return 4;
            else if (stage == -1)
                return (double)2 / 3;
            else if (stage == -2)
                return (double)2 / 4;
            else if (stage == -3)
                return (double)2 / 5;
            else if (stage == -4)
                return (double)2 / 6;
            else if (stage == -5)
                return (double)2 / 7;
            else if (stage == -6)
                return (double)2 / 8;
            else
                return 1;
        }
    }
}

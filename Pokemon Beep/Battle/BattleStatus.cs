using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class BattleStatus
    {
        public int[] player = new int[5];
        public int[] ai = new int[5];
        public BattleStatus()
        {
            Weather = 0;

            for (int i = 0; i < player.Length; i++)
            {
                player[i] = 0;
                ai[i] = 0;
            }
        }
        public BattleStatus(int weather)
        {
            Weather = weather;

            for (int i = 0; i < player.Length; i++)
            {
                player[i] = 0;
                ai[i] = 0;
            }
        }
        public double getStageMultiplicator(int stage)
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
        public int Weather { get; set; }
    }
}

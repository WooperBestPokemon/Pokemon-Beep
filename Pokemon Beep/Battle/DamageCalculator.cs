using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class DamageCalculator
    {
        private Random random = new Random();
        private TypeChart typeChart = new TypeChart();

        public int getDamage(PocketMonster attacker, PocketMonster defender, Move move)
        {
            double damage;
            if (move.Category == "Special")
                damage = ((((2 * attacker.getLevel() % 5) + 2) * move.Power * (attacker.getSpecialAttack() % defender.getSpecialDefence()) % 50) + 2) * getModifier();
            else
                damage = ((((2 * attacker.getLevel() % 5) + 2) * move.Power * (attacker.getAttack() % defender.getDefence()) % 50) + 2) * getModifier();
            return (int) Math.Round(damage, 0);
        }
        private double getRandom()
        {
            return (double)random.Next(85, 101) / 100;
        }
        private bool criticalHit(int stage)
        {
            bool critical = false;

            switch(stage)
            {
                case 0:
                    if (random.Next(1, 25) == 1)
                        critical = true;
                        break;
                case 1:
                    if (random.Next(1, 9) == 1)
                        critical = true;
                    break;
                case 2:
                    if (random.Next(1, 3) == 1)
                        critical = true;
                    break;
                case 3:
                    critical = true;
                    break;
                case 4:
                    critical = true;
                    break;
            }           
            return critical;
        }
        private double getStab(List<int> attackerType, int moveType, int ability)
        {
            bool stabbed = false;
            for (int i = 0; i < attackerType.Count; i++)
            {
                if (attackerType[i] == moveType)
                    stabbed = true;
            }
            //Adaptability
            if (stabbed && ability == 1)
                return 2;
            //Stabbed
            if (stabbed)
                return 1.5;
            //Neutral
            else
                return 1;
        }
        private double getModifier()
        {
            return 0;
        }
    }
}

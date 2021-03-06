﻿using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;

namespace Pokemon_Beep.Combat
{
    class DamageCalculator
    {
        /// <summary>
        /// This class calculate the damage output of an attack. It take both attacking/defending pokemon, the move and the status of the battle, then calculate the damage.
        /// </summary>
        private Random random = new Random();
        private TypeChart typeChart = new TypeChart();
        public int getDamage(PocketMonster attacker, PocketMonster defender, Move move, int weatherID)
        {
            double damage;
            //Physical Attack
            if (move.Category == "Physical")
            {
                double attackAttacker = attacker.Attack * getStageMultiplicator(attacker.Stages[(int)Enum.stat.Attack]);
                double defenseDefender = defender.Defense * getStageMultiplicator(defender.Stages[(int)Enum.stat.Defense]);
                damage = ((((2 * attacker.Level / 5) + 2) * attackAttacker * move.Power / defenseDefender / 50) + 2) * modifier(weatherID, attacker, defender, move);
            }
            //Special Attack
            else
            {
                double specialAttackAttacker = attacker.SpAttack * getStageMultiplicator(attacker.Stages[(int)Enum.stat.SpecialAttack]);
                double specialDefenseDefender = defender.SpDefense * getStageMultiplicator(defender.Stages[(int)Enum.stat.SpecialDefense]);
                damage = ((((2 * attacker.Level / 5) + 2) * specialAttackAttacker * move.Power / specialDefenseDefender / 50) + 2) * modifier(weatherID, attacker, defender, move);
            }                
            return (int) Math.Round(damage, 0);
        }
        //Modifier
        private double modifier(int weatherID, PocketMonster attacker, PocketMonster defender, Move move)
        {
            return weather(weatherID, move.Type) * criticalHit(attacker.Stages[(int)Enum.stat.Critical]) * randomDamage() * stab(attacker.Types, move.Type) * effectiveness(move.Type, defender) * burn(attacker, move.Category) * other();
        }
        //Private Function used by Modifier
        private double weather(int weatherID, int typeAttack)
        {
            double multiplicator = 1;

            switch (weatherID)
            {
                //Rain
                case 1:
                    if (typeAttack == (int)Enum.type.Water)
                        multiplicator = 1.5;
                    else if (typeAttack == (int)Enum.type.Fire)
                        multiplicator = 0.5;
                    break;
                //Sunny
                case 2:
                    if (typeAttack == (int)Enum.type.Fire)
                        multiplicator = 1.5;
                    else if (typeAttack == (int)Enum.type.Water)
                        multiplicator = 0.5;
                    break;
            }

            return multiplicator;
        }
        private double criticalHit(int stageCritical)
        {
            double critical = 1;
            switch(stageCritical)
            {
                case 0:
                    if (random.Next(1, 25) == 1)
                        critical = 1.5;
                        break;
                case 1:
                    if (random.Next(1, 9) == 1)
                        critical = 1.5;
                    break;
                case 2:
                    if (random.Next(1, 3) == 1)
                        critical = 1.5;
                    break;
                case 3:
                    critical = 1.5;
                    break;
                case 4:
                    critical = 1.5;
                    break;
            }
                
            return critical;
        }
        private double randomDamage()
        {
            return (double)Utilities.RandomNumber(85, 100) / 100;
        }
        private double stab(List<int> attackerType, int moveType)
        {
            bool stabbed = false;
            for (int i = 0; i < attackerType.Count; i++)
            {
                if (attackerType[i] == moveType)
                    stabbed = true;
            }
            //Stabbed
            if (stabbed)
                return 1.5;
            //Neutral
            else
                return 1;
        }
        private double effectiveness(int typeMove, PocketMonster defender)
        {
            return typeChart.effectivity(typeMove, defender);
        }
        private double burn(PocketMonster attacker, string categoryMove)
        {
            double burn = 1;
            if(attacker.Status == (int)Enum.status.Burned)
            {
                if (categoryMove == "Physical")
                {
                    if (!(attacker.PkmnAbility.Name == "Guts"))
                    {
                        burn = 0.5;
                    }
                }
            }
            return burn;
        }
        //Other is when an Object/Ability boost the attack.
        private double other()
        {
            //todo - object/ability
            double other = 1;
            return other;
        }
        private double getStageMultiplicator(int stage)
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
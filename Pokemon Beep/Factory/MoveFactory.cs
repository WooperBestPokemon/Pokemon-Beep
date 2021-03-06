﻿using Pokemon_Beep.Combat;
using Pokemon_Beep.Player;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Beep.Factory
{
    class MoveFactory
    {
        delegate void effect(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage);
        DamageCalculator calculator = new DamageCalculator();
        public List<Move> GetMoves()
        {
            List<Move> moves = new List<Move>();

            //Effects
            void noEffectVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            { }
            effect noEffect = new effect(noEffectVoid);
            //Lower Attack
            void foeLowerAttack1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] -= 1; 
            }
            void lowerA2(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] -= 2;
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] = -6;
            }
            void foeMayLowerAttack1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] -= 1;
                }
            }
            effect foeLowerAttack1Stage = new effect(foeLowerAttack1StageVoid);
            effect foeLowerAttack2Stage = new effect(lowerA2);
            effect foeMayLowerAttack1Stage = new effect(foeMayLowerAttack1StageVoid);
            //Lower Defense
            void foeLowerDefense1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] -= 1; 
            }
            void foeLowerDefense2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] -= 2;
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] < -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] = -6;
            }
            void foeMayLowerDefense1StageVoid20(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 2)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] -= 1;
                }
            }
            void foeMayLowerDefense1StageVoid30(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            { 
                if (Utilities.RandomNumber(1, 11) <= 3)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] -= 1;
                }
            }
            void foeMayLowerDefense1StageVoid50(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 5)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] -= 1;
                }
            }
            effect foeLowerDefense1Stage = new effect(foeLowerDefense1StageVoid);
            effect foeLowerDefense2Stage = new effect(foeLowerDefense2StageVoid);
            effect foeMayLowerDefense1Stage20 = new effect(foeMayLowerDefense1StageVoid20);
            effect foeMayLowerDefense1Stage30 = new effect(foeMayLowerDefense1StageVoid30);
            effect foeMayLowerDefense1Stage50 = new effect(foeMayLowerDefense1StageVoid50);
            //Lower Special Attack
            void foeLowerSpecialAttack1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] -= 1; 
            }
            void foeLowerSpecialAttack2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] -= 2;
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] < -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] = -6;
            }
            void foeMayLowerSpecialAttack1StageVoid30(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 3)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] -= 1;
                }
            }
            effect foeLowerSpecialAttack1Stage = new effect(foeLowerSpecialAttack1StageVoid);
            effect foeLowerSpecialAttack2Stage = new effect(foeLowerSpecialAttack2StageVoid);
            effect foeMayLowerSpecialAttack1Stage30 = new effect(foeMayLowerSpecialAttack1StageVoid30);
            //Lower Special Defense
            void foeLowerSpecialDefense2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] -= 2;
                if(defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] < -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] = -6;
            }
            void foeMayLowerSpecialDefense1StageVoid10(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 1)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] -= 1;
                }
            }
            void foeMayLowerSpecialDefense1StageVoid20(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 2)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] -= 1;
                }                  
            }
            effect foeLowerSpecialDefense2Stages = new effect(foeLowerSpecialDefense2StageVoid);
            effect foeMayLowerSpecialDefense1Stage10 = new effect(foeMayLowerSpecialDefense1StageVoid10);
            effect foeMayLowerSpecialDefense1Stage20 = new effect(foeMayLowerSpecialDefense1StageVoid20);
            //Lower Speed
            void foeLowerSpeed1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] -= 1; 
            }
            void foeLowerSpeed2StagesVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] -= 2;
                if(defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] < -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] = -6;
            }
            effect foeLowerSpeed1Stage = new effect(foeLowerSpeed1StageVoid);
            effect foeLowerSpeed2Stages = new effect(foeLowerSpeed2StagesVoid);
            //Lower Evasion
            void foeLowerEvasivenessVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] -= 1; 
            }
            effect foeLowerEvasiveness = new effect(foeLowerEvasivenessVoid);
            //Lower Accuracy
            void foeLowerAccuracy1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] -= 1; 
            }
            void foeMayLowerAccuracy1StageVoid30(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 3)
                {
                    if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] -= 1;
                }
            }
            void foeMayLowerAccuracy1StageVoid50(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 5)
                {
                    if(defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] > -6)
                        defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] -= 1;
                }
            }
            effect foeLowerAccuracy1Stage = new effect(foeLowerAccuracy1StageVoid);
            effect foeMayLowerAccuracy1Stage30 = new effect(foeMayLowerAccuracy1StageVoid30);
            effect foeMayLowerAccuracy1Stage50 = new effect(foeMayLowerAccuracy1StageVoid50);
            //Raise Attack
            void selfRaiseAttack1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
            }
            effect selfRaiseAttack1Stage = new effect(selfRaiseAttack1StageVoid);
            void selfRaiseAttack2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 2;
                if(attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] = 6;
            }
            effect selfRaiseAttack2Stage = new effect(selfRaiseAttack2StageVoid);
            void selfRaiseAttack1StageVoid10(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
                }
            }
            effect selfRaiseAttack1Stage10 = new effect(selfRaiseAttack1StageVoid10);
            //Raise Defense
            void selfRaiseDefense1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] += 1;
            }
            void selfRaiseDefense2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] += 2;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] = 6;
            }           
            void selfRaiseDefense3StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] += 3;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] = 6;
            }
            effect selfRaiseDefense1Stage = new effect(selfRaiseDefense1StageVoid);
            effect selfRaiseDefense2Stage = new effect(selfRaiseDefense2StageVoid);
            effect selfRaiseDefense3Stage = new effect(selfRaiseDefense3StageVoid);
            //Raise Special Attack
            void selfRaiseSpecialAttack1Stage70Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 7)
                {
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] += 1;
                }
            }
            void selfRaiseSpecialAttack2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] += 2;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] > 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] = 6;
            }
            effect selfRaiseSpecialAttack1Stage70 = new effect(selfRaiseSpecialAttack1Stage70Void);
            effect selfRaiseSpecialAttack2Stage = new effect(selfRaiseSpecialAttack2StageVoid);
            //Raise Special Defense
            void selfRaiseSpecialDefense2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] += 2;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] > 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] = 6;
            }
            effect selfRaiseSpecialDefense2Stage = new effect(selfRaiseSpecialDefense2StageVoid);
            //Speed
            void selfRaiseSpeed1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] += 1;
            }
            void selfRaiseSpeed2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] += 2;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] > 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] = 6;
            }
            effect selfRaiseSpeed1Stage = new effect(selfRaiseSpeed1StageVoid);
            effect selfRaiseSpeed2Stage = new effect(selfRaiseSpeed2StageVoid);
            //Evasion
            void selfRaiseEvasion1StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] += 1;
            }
            void selfRaiseEvasion2StageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] += 2;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] > 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Evasion] = 6;
            }
            effect selfRaiseEvasion1Stage = new effect(selfRaiseEvasion1StageVoid);
            effect selfRaiseEvasion2Stage = new effect(selfRaiseEvasion2StageVoid);
            //Critical
            void focusEnergyVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Critical] < 2)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Critical] = 2;
            }
            effect focusEnergy = new effect(focusEnergyVoid);
            //Meteo
            void rainVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                WeatherID = (int)Enum.weather.Rain;
            }
            void sandstormVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                WeatherID = (int)Enum.weather.Sandstorm;
            }
            void sunnyVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                WeatherID = (int)Enum.weather.Sunny;
            }
            void hailVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                WeatherID = (int)Enum.weather.Hail;
            }
            effect rain = new effect(rainVoid);
            effect sandstorm = new effect(sandstormVoid);
            effect sunny = new effect(sunnyVoid);
            effect hail = new effect(hailVoid);
            //Burn
            void burnVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                    attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Burned;
            }           
            void burnVoid10(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Burned;
                }
            }           
            void burnVoid30(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 3)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Burned;
                }
            }
            void burnVoid50(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 5)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Burned;
                }
            }
            effect burn = new effect(burnVoid);
            effect burn10 = new effect(burnVoid10);
            effect burn30 = new effect(burnVoid30);
            effect burn50 = new effect(burnVoid50);
            //Paralysis
            void paralysisVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                    attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Paralyzed;
            }
            void paralysisVoid10(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Paralyzed;
                }
            }
            void paralysisVoid30(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 3)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Paralyzed;
                }
            }
            effect paralysis = new effect(paralysisVoid);
            effect paralysis10 = new effect(paralysisVoid10);
            effect paralysis30 = new effect(paralysisVoid30);
            //Poison
            void poisonVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                    attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Poisoned;
            }
            void poison10Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Poisoned;
                }
            }
            void poison30Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 3)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Poisoned;
                }
            }
            void badlyPoisonVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {

                if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                    attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Badly_Poisoned;
            }
            effect poison = new effect(poisonVoid);
            effect poison10 = new effect(poison10Void);
            effect poison30 = new effect(poison30Void);
            effect badlyPoison = new effect(badlyPoisonVoid);
            //Freeze
            void freeze10Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Frozen;
                }
            }
            effect freeze10 = new effect(freeze10Void);
            //Sleep
            void sleepVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                    attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Sleep;
            }
            effect sleep = new effect(sleepVoid);
            //Yawn
            void yawnVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Sleepy == 0)
                    defender.PokemonInfo.Sleepy = 1;
            }
            effect yawn = new effect(yawnVoid);
            //Confusion
            void confusionVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Confused == 0)
                {
                    int nbTurn = Utilities.RandomNumber(1, 5);
                    defender.PokemonInfo.Confused = nbTurn;
                }
            }
            void confusion10Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (defender.PokemonInfo.Confused == 0)
                    {
                        int nbTurn = Utilities.RandomNumber(1, 5);
                        defender.PokemonInfo.Confused = nbTurn;
                    }
                }
            }
            void confusion20Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 2)
                {
                    if (defender.PokemonInfo.Confused == 0)
                    {
                        int nbTurn = Utilities.RandomNumber(1, 5);
                        defender.PokemonInfo.Confused = nbTurn;
                    }
                }
            }
            effect confusion = new effect(confusionVoid);
            effect confusion10 = new effect(confusion10Void);
            effect confusion20 = new effect(confusion20Void);
            //Block
            void blockVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Blocked == false)
                    defender.PokemonInfo.Blocked = true;
            }
            effect block = new effect(blockVoid);
            //Attract
            void attractVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(defender.PokemonInfo.Pokemon.Gender != attacker.PokemonInfo.Pokemon.Gender)
                {
                    if (defender.PokemonInfo.Attracted == false)
                        defender.PokemonInfo.Attracted = true;
                }
            }
            effect attract = new effect(attractVoid);
            //Leech Seeds
            void leechSeedVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(!(defender.PokemonInfo.Pokemon.Types.Contains((int)Enum.type.Grass)))
                {
                    if (defender.PokemonInfo.Leeched == false)
                        defender.PokemonInfo.Leeched = true;
                }
            }
            effect leechSeed = new effect(leechSeedVoid);
            //Flinch
            void flinch10Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                    defender.PokemonInfo.Stunned = true;
            }
            void flinch20Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 2)
                    defender.PokemonInfo.Stunned = true;
            }
            void flinch30Void(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) <= 3)
                    defender.PokemonInfo.Stunned = true;
            }
            effect flinch10 = new effect(flinch10Void);
            effect flinch20 = new effect(flinch20Void);
            effect flinch30 = new effect(flinch30Void);
            //Recoil
            void recoilTwoVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                double recoilHP = damage / 2;
                attacker.PokemonInfo.Pokemon.CurrentHP -= (int)Math.Round(recoilHP, 0);
            }
            void recoilThreeVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                double recoilHP = damage / 3;
                attacker.PokemonInfo.Pokemon.CurrentHP -= (int)Math.Round(recoilHP, 0);
            }
            void recoilFourVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                double recoilHP = damage / 4;
                attacker.PokemonInfo.Pokemon.CurrentHP -= (int)Math.Round(recoilHP, 0);
            }
            effect recoilTwo = new effect(recoilTwoVoid);
            effect recoilThree = new effect(recoilThreeVoid);
            effect recoilFour = new effect(recoilFourVoid);
            //Multi-Hit
            void bulletSeedVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 25, 100, 10, (int)Enum.type.Grass, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect bulletSeed = new effect(bulletSeedVoid);
            void cometPunchVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 18, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect cometPunch = new effect(cometPunchVoid);
            void icicleVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 25, 100, 10, (int)Enum.type.Ice, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect icicle = new effect(icicleVoid);
            void pinVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 25, 100, 10, (int)Enum.type.Bug, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect pin = new effect(pinVoid);
            void rockBlastVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 25, 100, 10, (int)Enum.type.Rock, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect rockBlast = new effect(rockBlastVoid);
            void scaleShotVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 25, 100, 10, (int)Enum.type.Dragon, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect scaleShot = new effect(scaleShotVoid);
            void spikeCannonVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 20, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect spikeCannon = new effect(spikeCannonVoid);
            void tailSlapVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbOfHit = Utilities.RandomNumber(1, 5);
                for (int i = 0; i < nbOfHit; i++)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 25, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                //nbOfHit + 1 = total number of hit
            }
            effect tailSlap = new effect(tailSlapVoid);
            //Must Recharge
            void mustRechargeVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                attacker.PokemonInfo.MustRecharge = true;
            }
            effect mustRecharge = new effect(mustRechargeVoid);
            //Protect and stuff
            void endureVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                attacker.PokemonInfo.Endure = true;
            }
            effect endure = new effect(endureVoid);
            void protectVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                attacker.PokemonInfo.Protected = true;
            }
            effect protect = new effect(protectVoid);
            //Multi Moves with Status Problem
            void iceFangVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                    defender.PokemonInfo.Stunned = true;
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Frozen;
                }
            }            
            void fireFangVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                    defender.PokemonInfo.Stunned = true;
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Burned;
                }
            }            
            void thunderFangVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                    defender.PokemonInfo.Stunned = true;
                if (Utilities.RandomNumber(1, 11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.None)
                        attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Burned;
                }
            }
            effect iceFang = new effect(iceFangVoid);
            effect fireFang = new effect(fireFangVoid);
            effect thunderFang = new effect(thunderFangVoid);
            void crossPoisonVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (Utilities.RandomNumber(1, 11) == 1)
                    attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Poisoned;
            }
            effect crossPoison = new effect(crossPoisonVoid);
            void dragonDanceVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] += 1;
            }
            effect dragonDance = new effect(dragonDanceVoid);
            //Growth
            void growthVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(WeatherID == (int)Enum.weather.Sunny)
                {
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 2;
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] += 2;
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] = 6;
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] > 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] = 6;
                }
                else
                {
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] += 1;
                }
            }
            effect growth = new effect(growthVoid);
            void coilVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] += 1;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] += 1;
            }
            effect coil = new effect(coilVoid);
            void superpowerVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > -6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] -= 1;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > -6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] -= 1;
            }
            effect superpower = new effect(superpowerVoid);
            void ancientPowerVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(Utilities.RandomNumber(1,11) == 1)
                {
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] += 1;
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] += 1;
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialDefense] += 1;
                    if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] < 6)
                        attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Speed] += 1;
                }
            }
            effect ancientPower = new effect(ancientPowerVoid);
            void psychVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                attacker.PokemonInfo.Pokemon.Stages = defender.PokemonInfo.Pokemon.Stages;
            }
            effect psych = new effect(psychVoid);
            void tickleVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] -= 1;
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] > -6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Defense] -= 1;
            }
            effect tickle = new effect(tickleVoid);
            void honeClawsVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Accuracy] += 1;
            }
            effect honeClaws = new effect(honeClawsVoid);
            void workUpVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 1;
                if (attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] < 6)
                    attacker.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] += 1;
            }
            effect workUp = new effect(workUpVoid);
            void resetStatVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                for (int i = 0; i < attacker.PokemonInfo.Pokemon.Stages.Count(); i++)
                {
                    attacker.PokemonInfo.Pokemon.Stages[i] = 0;
                    defender.PokemonInfo.Pokemon.Stages[i] = 0;
                }
            }
            effect resetStat = new effect(resetStatVoid);
            void electroBallVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                double ratio = attacker.PokemonInfo.Pokemon.Speed / defender.PokemonInfo.Pokemon.Speed;
                if (4 <= ratio)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 150, 100, 10, (int)Enum.type.Electric, noEffect, "Special", ""), WeatherID);
                else if (3 <= ratio)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 120, 100, 10, (int)Enum.type.Electric, noEffect, "Special", ""), WeatherID);
                else if (2 <= ratio)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 80, 100, 10, (int)Enum.type.Electric, noEffect, "Special", ""), WeatherID);
                else if (1 <= ratio)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 60, 100, 10, (int)Enum.type.Electric, noEffect, "Special", ""), WeatherID);
                else
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 40, 100, 10, (int)Enum.type.Electric, noEffect, "Special", ""), WeatherID);
            }
            effect electroBall = new effect(electroBallVoid);
            void flailVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                double ratio = 48 * attacker.PokemonInfo.Pokemon.CurrentHP / attacker.PokemonInfo.Pokemon.HP;
                if(0 <= ratio && ratio <= 2)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 200, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                else if (2 <= ratio && ratio <= 4)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 150, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                else if(5 <= ratio && ratio <= 9)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 100, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                else if (10 <= ratio && ratio <= 16)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 80, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                else if (17 <= ratio && ratio <= 32)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 40, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                else
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 20, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
            }
            effect flail = new effect(flailVoid);
            void superFangVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int damageHP = defender.PokemonInfo.Pokemon.CurrentHP / 2;
                defender.PokemonInfo.Pokemon.CurrentHP -= damageHP;
            }
            effect superFang = new effect(superFangVoid);
            void dragonRageVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                defender.PokemonInfo.Pokemon.CurrentHP -= 40;
            }
            effect dragonRage = new effect(dragonRageVoid);
            void suckerPunchVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Moveset[foeMove].Category != "Status")
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 70, 100, 5, (int)Enum.type.Dark, noEffect, "Physical", ""), WeatherID);
            }
            effect suckerPunch = new effect(suckerPunchVoid);
            void flameBlitzVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                double recoilHP = damage / 3;
                if (Utilities.RandomNumber(1, 11) == 1)
                    attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Burned;
                attacker.PokemonInfo.Pokemon.CurrentHP -= (int)Math.Round(recoilHP, 0);
            }
            effect flameBlitz = new effect(flameBlitzVoid);
            void restVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                attacker.PokemonInfo.Pokemon.CurrentHP = attacker.PokemonInfo.Pokemon.HP;
                attacker.PokemonInfo.Pokemon.Status = (int)Enum.status.Sleep;
            }
            effect rest = new effect(restVoid);
            void roostVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                attacker.PokemonInfo.Pokemon.CurrentHP += attacker.PokemonInfo.Pokemon.HP / 2;
                if (attacker.PokemonInfo.Pokemon.CurrentHP > attacker.PokemonInfo.Pokemon.HP)
                    attacker.PokemonInfo.Pokemon.CurrentHP = attacker.PokemonInfo.Pokemon.HP;
            }
            effect roost = new effect(roostVoid);
            void swaggerVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] < 6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] += 2;
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] > 6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.Attack] = 6;
                if (defender.PokemonInfo.Confused == 0)
                {
                    int nbTurn = Utilities.RandomNumber(1, 5);
                    defender.PokemonInfo.Confused = nbTurn;
                }
            }
            effect swagger = new effect(swaggerVoid);
            void flatterVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] < 6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] += 2;
                if (defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] > 6)
                    defender.PokemonInfo.Pokemon.Stages[(int)Enum.stat.SpecialAttack] = 6;
                if (defender.PokemonInfo.Confused == 0)
                {
                    int nbTurn = Utilities.RandomNumber(1, 5);
                    defender.PokemonInfo.Confused = nbTurn;
                }
            }
            effect flatter = new effect(flatterVoid);
            void stormVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                int nbTurn = Utilities.RandomNumber(2, 4);
                attacker.PokemonInfo.Stormed = nbTurn;
            }
            effect storm = new effect(stormVoid);
            void endeavorVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(attacker.PokemonInfo.Pokemon.CurrentHP < defender.PokemonInfo.Pokemon.CurrentHP)
                    defender.PokemonInfo.Pokemon.CurrentHP = attacker.PokemonInfo.Pokemon.CurrentHP;
            }
            effect endeavor = new effect(endeavorVoid);
            void facadeVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.Burned || attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.Poisoned || attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.Badly_Poisoned || attacker.PokemonInfo.Pokemon.Status == (int)Enum.status.Paralyzed)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 140, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
                else
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 70, 100, 10, (int)Enum.type.Normal, noEffect, "Physical", ""), WeatherID);
            }
            effect facade = new effect(facadeVoid);
            void brineVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Pokemon.CurrentHP <= defender.PokemonInfo.Pokemon.HP/2)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 130, 100, 10, (int)Enum.type.Water, noEffect, "Special", ""), WeatherID);
                else
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 65, 100, 10, (int)Enum.type.Water, noEffect, "Special", ""), WeatherID);
            }
            effect brine = new effect(brineVoid);
            void splashVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                //insert "nothing happen"
            }
            effect splash = new effect(splashVoid);
            void assuranceVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(defender.PokemonInfo.tookDamage)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 120, 100, 10, (int)Enum.type.Dark, noEffect, "Physical", ""), WeatherID);
                else
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 60, 100, 10, (int)Enum.type.Dark, noEffect, "Physical", ""), WeatherID);
            }
            effect assurance = new effect(assuranceVoid);
            void tormentVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Tormented == false)
                    defender.PokemonInfo.Tormented = true;
            }
            effect torment = new effect(tormentVoid);
            void tauntVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (defender.PokemonInfo.Taunted == 0)
                {
                    int nbTurn = Utilities.RandomNumber(2, 5);
                    defender.PokemonInfo.Taunted = nbTurn;
                }
                    
            }
            effect taunt = new effect(tauntVoid);
            void lightScreenVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.LightScreen == 0)
                    attacker.LightScreen = 5;
            }
            effect lightScreen = new effect(lightScreenVoid);
            void reflectVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if (attacker.Reflect == 0)
                    attacker.Reflect = 5;
            }
            effect reflect = new effect(reflectVoid);
            void aromatherapyVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                for (int i = 0; i < player.Pokemons.Count; i++)
                {
                    if (player.Pokemons[i].Status != 0)
                        player.Pokemons[i].Status = 0;
                }
            }
            effect aromatherapy = new effect(aromatherapyVoid);
            void grassKnotVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                double weight = Pokedex.getInfo(defender.PokemonInfo.Pokemon.PokedexID).Weight;
                if(weight < 10)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 20, 100, 20, (int)Enum.type.Grass, noEffect, "Special", ""), WeatherID);
                else if(weight < 25)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 40, 100, 20, (int)Enum.type.Grass, noEffect, "Special", ""), WeatherID);
                else if (weight < 50)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 60, 100, 20, (int)Enum.type.Grass, noEffect, "Special", ""), WeatherID);
                else if (weight < 100)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 80, 100, 20, (int)Enum.type.Grass, noEffect, "Special", ""), WeatherID);
                else if (weight < 200)
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 100, 100, 20, (int)Enum.type.Grass, noEffect, "Special", ""), WeatherID);
                else
                    defender.PokemonInfo.Pokemon.CurrentHP -= calculator.getDamage(attacker.PokemonInfo.Pokemon, defender.PokemonInfo.Pokemon, new Move("", 120, 100, 20, (int)Enum.type.Grass, noEffect, "Special", ""), WeatherID);

            }
            effect grassKnot = new effect(grassKnotVoid);
            void brickBreakVoid(Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage)
            {
                if(defender.LightScreen > 0)
                    defender.LightScreen = 0;
                if (defender.Reflect > 0)
                    defender.Reflect = 0;
            }
            effect brickBreak = new effect(brickBreakVoid);

            //Moves with no effect
            moves.Add(new Move("Aqua Tail", 90, 90, 10, (int)Enum.type.Water, noEffect, "Physical", "The user attacks by swinging its tail as if it were a vicious wave in a raging storm."));
            moves.Add(new Move("Cut", 65, 100, 30, (int)Enum.type.Grass, noEffect, "Physical", "The foe is cut with a scythe or a claw. It can also be used to cut down thin trees."));
            moves.Add(new Move("Dragon Claw", 80, 100, 15, (int)Enum.type.Dragon, noEffect, "Physical", "The user slashes the foe with huge, sharp claws."));
            moves.Add(new Move("Dragon Pulse", 85, 100, 10, (int)Enum.type.Dragon, noEffect, "Special", "The foe is attacked with a shock wave generated by the user's gaping mouth."));
            moves.Add(new Move("Drill Peck", 80, 100, 20, (int)Enum.type.Fly, noEffect, "Physical", "A corkscrewing attack with the sharp beak acting as a drill."));
            moves.Add(new Move("Egg Bomb", 100, 75, 10, (int)Enum.type.Normal, noEffect, "Physical", "A large egg is hurled with maximum force at the foe to inflict damage."));
            moves.Add(new Move("Fairy Wind", 40, 100, 30, (int)Enum.type.Fairy, noEffect, "Special", "The user stirs up a fairy wind and strikes the target with it."));
            moves.Add(new Move("Horn Attack", 65, 100, 25, (int)Enum.type.Normal, noEffect, "Physical", "The foe is jabbed with a sharply pointed horn to inflict damage."));
            moves.Add(new Move("Hydro Pump", 110, 80, 5, (int)Enum.type.Water, noEffect, "Special", "The foe is blasted by a huge volume of water launched under great pressure."));
            moves.Add(new Move("Hyper Voice", 90, 100, 10, (int)Enum.type.Normal, noEffect, "Special", "The user lets loose a horribly echoing shout with the power to inflict damage."));
            moves.Add(new Move("Mega Kick", 120, 75, 5, (int)Enum.type.Normal, noEffect, "Physical", "The foe is attacked by a kick launched with muscle-packed power."));
            moves.Add(new Move("Mega Punch", 80, 85, 20, (int)Enum.type.Normal, noEffect, "Physical", "The foe is slugged by a punch thrown with muscle-packed power."));
            moves.Add(new Move("Megahorn", 120, 85, 10, (int)Enum.type.Bug, noEffect, "Physical", "Utilizing its tough and impressive horn, the user rams into the foe with no letup."));
            moves.Add(new Move("Peck", 35, 100, 35, (int)Enum.type.Fly, noEffect, "Physical", "The foe is jabbed with a sharply pointed beak or horn."));
            moves.Add(new Move("Pound", 40, 100, 35, (int)Enum.type.Normal, noEffect, "Physical", "The foe is physically pounded with a long tail or a foreleg, etc."));
            moves.Add(new Move("Power Gem", 80, 100, 20, (int)Enum.type.Rock, noEffect, "Special", "The user attacks with a ray of light that sparkles as if it were made of gemstones."));
            moves.Add(new Move("Power Whip", 120, 85, 10, (int)Enum.type.Grass, noEffect, "Physical", "The user violently whirls its vines or tentacles to harshly lash the foe."));
            moves.Add(new Move("Rock Throw", 50, 90, 15, (int)Enum.type.Rock, noEffect, "Physical", "The user picks up and throws a small rock at the foe to attack."));
            moves.Add(new Move("Scratch", 40, 100, 35, (int)Enum.type.Normal, noEffect, "Physical", "Hard, pointed, and sharp claws rake the foe to inflict damage."));
            moves.Add(new Move("Seed Bomb", 80, 100, 15, (int)Enum.type.Grass, noEffect, "Physical", "The user slams a barrage of hard-shelled seeds down on the foe from above."));
            moves.Add(new Move("Slam", 80, 75, 20, (int)Enum.type.Normal, noEffect, "Physical", "The foe is slammed with a long tail, vines, etc., to inflict damage."));
            moves.Add(new Move("Strength", 80, 100, 15, (int)Enum.type.Fighting, noEffect, "Physical", "The foe is slugged with a punch thrown at maximum power."));
            moves.Add(new Move("Tackle", 40, 100, 35, (int)Enum.type.Normal, noEffect, "Physical", "A physical attack in which the user charges and slams into the foe with its whole body."));
            moves.Add(new Move("Vine Whip", 45, 100, 25, (int)Enum.type.Grass, noEffect, "Physical", "The foe is struck with slender, whiplike vines to inflict damage."));
            moves.Add(new Move("Water Gun", 40, 100, 25, (int)Enum.type.Water, noEffect, "Special", "The foe is blasted with a forceful shot of water."));
            moves.Add(new Move("Wing Attack", 60, 100, 35, (int)Enum.type.Fly, noEffect, "Physical", "The foe is struck with large, imposing wings spread wide to inflict damage."));
            moves.Add(new Move("X-Scissor", 80, 100, 15, (int)Enum.type.Bug, noEffect, "Physical", "The user slashes at the foe by crossing its scythes or claws as if they were a pair of scissors."));

            //Move with priority
            moves.Add(new Move("Quick Attack", 40, 100, 30, (int)Enum.type.Normal, noEffect, "Physical", 1 , "The user lunges at the foe at a speed that makes it almost invisible. It is sure to strike first."));
            moves.Add(new Move("Aqua Jet", 40, 100, 20, (int)Enum.type.Water, noEffect, "Physical", 1, "The user lunges at the foe at a speed that makes it almost invisible. It is sure to strike first."));

            //Move that lower attack
            moves.Add(new Move("Growl", 100, 40, (int)Enum.type.Normal, foeLowerAttack1Stage, "The user growls in an endearing way, making the foe less wary. The target's Attack stat is lowered."));
            moves.Add(new Move("Aurora Beam", 65, 100, 20, (int)Enum.type.Ice, foeMayLowerAttack1Stage, "Special", "The foe is hit with a rainbow-colored beam. It may also lower the target's Attack stat."));
            moves.Add(new Move("Play Rough", 90, 90, 10, (int)Enum.type.Fairy, foeMayLowerAttack1Stage, "Physical", "The user plays rough with the target and attacks it. This may also lower the target's Attack stat."));
            moves.Add(new Move("Charm", 100, 20, (int)Enum.type.Fairy, foeLowerAttack2Stage, "The user charmingly stares at the foe, making it less wary. The target's Attack is sharply lowered."));
            moves.Add(new Move("Feather Dance", 100, 15, (int)Enum.type.Fly, foeLowerAttack2Stage, "The user covers the foe with a mass of down that sharply lowers the Attack stat."));
            
            //Moves that lower defense
            moves.Add(new Move("Leer", 100, 30, (int)Enum.type.Normal, foeLowerDefense1Stage, "The foe is given an intimidating leer with sharp eyes. The target's Defense stat is reduced."));
            moves.Add(new Move("Tail Whip", 100, 30, (int)Enum.type.Normal, foeLowerDefense1Stage, "The user wags its tail cutely, making the foe less wary. The target's Defense stat is lowered."));
            moves.Add(new Move("Crunch", 80, 100, 15, (int)Enum.type.Dark, foeMayLowerDefense1Stage20, "Physical", "The user crunches up the foe with sharp fangs. It may also lower the target's Defense stat."));
            moves.Add(new Move("Liquidation", 85, 100, 10, (int)Enum.type.Water, foeMayLowerDefense1Stage20, "Physical", "The user slams into the target using a full-force blast of water. This may also lower the target's Defense stat."));
            moves.Add(new Move("Iron Tail", 100, 75, 15, (int)Enum.type.Steel, foeMayLowerDefense1Stage30, "Physical", "The foe is slammed with a steel-hard tail. It may also lower the target's Defense stat."));
            moves.Add(new Move("Crush Claw", 75, 95, 10, (int)Enum.type.Normal, foeMayLowerDefense1Stage50, "Physical", "The user slashes the foe with hard and sharp claws. It may also lower the target's Defense."));
            moves.Add(new Move("Razor Shell", 75, 95, 10, (int)Enum.type.Water, foeMayLowerDefense1Stage50, "Physical", "The user cuts its target with sharp shells. This attack may also lower the target's Defense stat."));
            moves.Add(new Move("Rock Smash", 40, 100, 15, (int)Enum.type.Rock, foeMayLowerDefense1Stage50, "Physical", "The user slugs the foe with a shattering punch. It can also smash cracked boulders."));
            moves.Add(new Move("Screech", 85, 40, (int)Enum.type.Normal, foeLowerDefense2Stage, "An earsplitting screech is emitted to sharply reduce the foe's Defense stat."));
            
            //Moves that lower special attack
            moves.Add(new Move("Confide", 100, 20, (int)Enum.type.Normal, foeLowerSpecialAttack1Stage, "The user tells the target a secret, and the target loses its ability to concentrate. This lowers the target's Sp. Atk stat."));
            moves.Add(new Move("Mystical Fire", 75, 100, 10, (int)Enum.type.Fire, foeLowerSpecialAttack1Stage, "Special", "The user attacks by breathing a special, hot fire. This also lowers the target's Sp. Atk stat."));
            moves.Add(new Move("Snarl", 55, 95, 15, (int)Enum.type.Dark, foeLowerSpecialAttack1Stage, "Special", "The user yells as if it is ranting about something, making the target's Sp. Atk stat decrease."));
            moves.Add(new Move("Struggle Bug", 50, 100, 20, (int)Enum.type.Bug, foeLowerSpecialAttack1Stage, "Special", "While resisting, the user attacks the opposing Pokémon. The targets' Sp. Atk stat is reduced."));
            moves.Add(new Move("Moonblast", 95, 100, 15, (int)Enum.type.Fairy, foeMayLowerSpecialAttack1Stage30, "Special", "Borrowing the power of the moon, the user attacks the target. This may also lower the target's Sp. Atk stat."));
            moves.Add(new Move("Eerie Impulse", 100, 15, (int)Enum.type.Electric, foeLowerSpecialAttack2Stage, "The user's body generates an eerie impulse. Exposing the target to it harshly lowers the target's Sp. Atk stat."));

            //Moves that lower Special Defense
            moves.Add(new Move("Acid", 40, 100, 30, (int)Enum.type.Poison, foeMayLowerSpecialDefense1Stage10, "Special", "The foe is attacked with a spray of harsh acid. It may also lower the target's Sp. Def stat."));
            moves.Add(new Move("Bug Buzz", 90, 100, 10, (int)Enum.type.Bug, foeMayLowerSpecialDefense1Stage10, "Special", "The user vibrates its wings to generate a damaging sound wave. It may also lower the foe's Sp. Def stat."));
            moves.Add(new Move("Earth Power", 90, 100, 10, (int)Enum.type.Ground, foeMayLowerSpecialDefense1Stage10, "Special", "The user makes the ground under the foe erupt with power. It may also lower the target's Sp. Def."));
            moves.Add(new Move("Energy Ball", 90, 100, 10, (int)Enum.type.Grass, foeMayLowerSpecialDefense1Stage10, "Special", "The user draws power from nature and fires it at the foe. It may also lower the target's Sp. Def."));
            moves.Add(new Move("Flash Cannon", 80, 100, 10, (int)Enum.type.Steel, foeMayLowerSpecialDefense1Stage10, "Special", "The user gathers all its light energy and releases it at once. It may also lower the foe's Sp. Def stat."));
            moves.Add(new Move("Focus Blast", 120, 70, 5, (int)Enum.type.Fighting, foeMayLowerSpecialDefense1Stage10, "Special", "The user heightens its mental focus and unleashes its power. It may also lower the target's Sp. Def."));
            moves.Add(new Move("Psychic", 90, 100, 10, (int)Enum.type.Psy, foeMayLowerSpecialDefense1Stage10, "Special", "The foe is hit by a strong telekinetic force. It may also reduce the foe's Sp. Def stat."));
            moves.Add(new Move("Shadow Ball", 80, 100, 15, (int)Enum.type.Ghost, foeMayLowerSpecialDefense1Stage20, "Special", "The user hurls a shadowy blob at the foe. It may also lower the foe's Sp. Def stat."));
            moves.Add(new Move("Acid Spray", 40, 100, 20, (int)Enum.type.Poison, foeLowerSpecialDefense2Stages, "Special", "The user spits fluid that works to melt the target. This harshly lowers the target's Sp. Def stat."));
            moves.Add(new Move("Fake Tears", 100, 20, (int)Enum.type.Dark, foeLowerSpecialDefense2Stages, "The user feigns crying to make the foe feel flustered, sharply lowering its Sp. Def stat."));
            moves.Add(new Move("Metal Sound", 85, 40, (int)Enum.type.Steel, foeLowerSpecialDefense2Stages, "A horrible sound like scraping metal is emitted to sharply reduce the foe's Sp. Def stat."));

            //Moves that lower Speed           
            moves.Add(new Move("Bulldoze", 60, 100, 20, (int)Enum.type.Ground, foeLowerSpeed1Stage, "Physical", "The user stomps down on the ground and attacks everything in the area. Hit Pokémon’s Speed stat is reduced."));
            moves.Add(new Move("Icy Wind", 55, 95, 15, (int)Enum.type.Ice, foeLowerSpeed1Stage, "Special", "The user attacks with a gust of chilled air. It also lowers the target's Speed stat."));
            moves.Add(new Move("Mud Shot", 55, 95, 15, (int)Enum.type.Ground, foeLowerSpeed1Stage, "Special", "The user attacks by hurling a blob of mud at the foe. It also reduces the target's Speed."));
            moves.Add(new Move("Rock Tomb", 60, 95, 15, (int)Enum.type.Rock, foeLowerSpeed1Stage, "Physical", "Boulders are hurled at the foe. It also lowers the foe's Speed by preventing its movement."));
            moves.Add(new Move("Cotton Spore", 100, 40, (int)Enum.type.Grass, foeLowerSpeed2Stages, "The user releases cottonlike spores that cling to the foe, sharply reducing its Speed stat."));
            moves.Add(new Move("Scary Face", 100, 10, (int)Enum.type.Normal, foeLowerSpeed2Stages, "The user frightens the foe with a scary face to sharply reduce its Speed stat."));
            moves.Add(new Move("String Shot", 95, 40, (int)Enum.type.Bug, foeLowerSpeed2Stages, "The foe is bound with silk blown from the user's mouth. It reduces the target's Speed stat."));

            //Moves that lower evasiveness
            moves.Add(new Move("Defog", 15, (int)Enum.type.Fly, foeLowerEvasiveness, "Obstacles are moved, reducing the foe’s evasion stat. It can also be used to clear deep fog, etc."));
            moves.Add(new Move("Sweet Scent", 100, 20, (int)Enum.type.Normal, foeLowerEvasiveness, "A sweet scent that lowers the foe’s evasiveness."));

            //Moves that lower Accuracy
            moves.Add(new Move("Flash", 100, 20, (int)Enum.type.Normal, foeLowerAccuracy1Stage, "The user flashes a light that cuts the foe’s accuracy. It can also be used to illuminate caves."));
            moves.Add(new Move("Mirror Shot", 65, 85, 10, (int)Enum.type.Steel, foeMayLowerAccuracy1Stage30, "Special", "The user looses a flash of energy from its polished body. It may also lower the target’s accuracy."));
            moves.Add(new Move("Mud Bomb", 65, 85, 10, (int)Enum.type.Ground, foeMayLowerAccuracy1Stage30, "Special", "The user launches a hard-packed mud ball to attack. It may also lower the target’s accuracy."));
            moves.Add(new Move("Mud-Slap", 20, 100, 10, (int)Enum.type.Ground, foeLowerAccuracy1Stage, "Special", "The user hurls mud in the foe’s face to inflict damage and lower its accuracy."));
            moves.Add(new Move("Muddy Water", 90, 85, 10, (int)Enum.type.Water, foeMayLowerAccuracy1Stage30, "Special", "The user attacks by shooting out muddy water. It may also lower the foe’s accuracy."));
            moves.Add(new Move("Octazooka", 65, 85, 10, (int)Enum.type.Water, foeMayLowerAccuracy1Stage50, "Special", "The user attacks by spraying ink in the foe’s face or eyes. It may also lower the target’s accuracy."));
            moves.Add(new Move("Sand Attack", 100, 15, (int)Enum.type.Ground, foeLowerAccuracy1Stage, "Sand is hurled in the foe’s face, reducing its accuracy."));
            moves.Add(new Move("Smokescreen", 100, 20, (int)Enum.type.Normal, foeLowerAccuracy1Stage, "The user releases an obscuring cloud of smoke or ink. It reduces the foe’s accuracy."));

            //Moves that raise Attack
            moves.Add(new Move("Meditate", 40, (int)Enum.type.Psy, selfRaiseAttack1Stage, "The user meditates to awaken the power deep within its body and raise its Attack stat."));
            moves.Add(new Move("Sharpen", 30, (int)Enum.type.Normal, selfRaiseAttack1Stage, "The user reduces its polygon count to make itself more jagged, raising the Attack stat."));
            moves.Add(new Move("Howl", 40, (int)Enum.type.Normal, selfRaiseAttack1Stage, "The user howls loudly to raise its spirit, boosting its Attack stat."));
            moves.Add(new Move("Swords Dance", 20, (int)Enum.type.Normal, selfRaiseAttack2Stage, "A frenetic dance to uplift the fighting spirit. It sharply raises the user's Attack stat."));
            moves.Add(new Move("Metal Claw", 50, 95, 35, (int)Enum.type.Steel, selfRaiseAttack1Stage10, "Physical", "The foe is raked with steel claws. It may also raise the user’s Attack stat."));

            //Moves that raise Defense
            moves.Add(new Move("Defense Curl", 40, (int)Enum.type.Normal, selfRaiseDefense1Stage, "The user curls up to conceal weak spots and raise its Defense stat."));
            moves.Add(new Move("Harden", 30, (int)Enum.type.Normal, selfRaiseDefense1Stage, "The user stiffens all the muscles in its body to raise its Defense stat."));
            moves.Add(new Move("Withdraw", 40, (int)Enum.type.Water, selfRaiseDefense1Stage, "The user withdraws its body into its hard shell, raising its Defense stat."));
            moves.Add(new Move("Acid Armor",20, (int)Enum.type.Poison, selfRaiseDefense2Stage, "The user alters its cellular structure to liquefy itself, sharply raising its Defense stat."));
            moves.Add(new Move("Barrier", 20, (int)Enum.type.Psy, selfRaiseDefense2Stage, "The user throws up a sturdy wall that sharply raises its Defense stat."));
            moves.Add(new Move("Iron Defense", 15, (int)Enum.type.Steel, selfRaiseDefense2Stage, "The user hardens its body's surface like iron, sharply raising its Defense stat."));
            moves.Add(new Move("Cotton Guard", 10, (int)Enum.type.Grass, selfRaiseDefense3Stage, "The user protects itself by wrapping its body in soft cotton, which drastically raises the user's Defense stat."));

            //Moves that raise Special Attack
            moves.Add(new Move("Charge Beam", 50, 90, 10, (int)Enum.type.Electric, selfRaiseSpecialAttack1Stage70, "Special", "The user fires a concentrated bundle of electricity. It may also raise the user's Sp. Atk stat."));
            moves.Add(new Move("Nasty Plot", 20, (int)Enum.type.Dark, selfRaiseSpecialAttack2Stage, "The user stimulates its brain by thinking bad thoughts. It sharply raises the user's Sp. Atk."));

            //Move that raise Special Defense
            moves.Add(new Move("Amnesia", 20, (int)Enum.type.Psy, selfRaiseSpecialDefense2Stage, "The user temporarily empties its mind to forget its concerns. It sharply raises the user's Sp. Def stat."));

            //Move that raise Speed
            moves.Add(new Move("Flame Charge", 50, 100, 20, (int)Enum.type.Fire, selfRaiseSpeed1Stage, "Physical", "Cloaking itself in flame, the user attacks the target. Then, building up more power, the user raises its Speed stat."));
            moves.Add(new Move("Agility", 30, (int)Enum.type.Psy, selfRaiseSpeed2Stage, "The user relaxes and lightens its body to move faster. It sharply boosts the Speed stat."));
            moves.Add(new Move("Rock Polish", 20, (int)Enum.type.Rock, selfRaiseSpeed2Stage, "The user polishes its body to reduce drag. It can sharply raise the Speed stat."));

            //Move that raise evasiveness
            moves.Add(new Move("Double Team", 15, (int)Enum.type.Normal, selfRaiseEvasion1Stage, "By moving rapidly, the user makes illusory copies of itself to raise its evasiveness."));
            moves.Add(new Move("Minimize", 10, (int)Enum.type.Normal, selfRaiseEvasion2Stage, "The user compresses its body to make itself look smaller. The user’s evasion stat is boosted."));

            //Move that raise Critical Ratio
            moves.Add(new Move("Focus_Energy", 15, (int)Enum.type.Normal, focusEnergy, "By moving rapidly, the user makes illusory copies of itself to raise its evasiveness."));

            //Move with High Critical Ratio
            moves.Add(new Move("Air Cutter", 60, 95, 25, (int)Enum.type.Fly, noEffect, "Special", "The user launches razorlike wind to slash the foe. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Crabhammer", 100, 90, 10, (int)Enum.type.Water, noEffect, "Physical", "The foe is hammered with a large pincer. This move has a high critical-hit ratio.", true));
            moves.Add(new Move("Cross Chop", 100, 80, 5, (int)Enum.type.Fighting, noEffect, "Physical", "The user delivers a double chop with its forearms crossed. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Drill Run", 80, 95, 10, (int)Enum.type.Ground, noEffect, "Physical", "The user crashes into its target while rotating its body like a drill. Critical hits land more easily.", true));
            moves.Add(new Move("Karate Chop", 50, 100, 25, (int)Enum.type.Fighting, noEffect, "Physical", "The foe is attacked with a sharp chop. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Leaf Blade", 90, 100, 15, (int)Enum.type.Grass, noEffect, "Physical", "The foe is slashed with a sharp leaf. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Night Slash", 70, 100, 15, (int)Enum.type.Dark, noEffect, "Physical", "The user slashes the foe the instant an opportunity arises. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Psycho Cut", 70, 100, 20, (int)Enum.type.Psy, noEffect, "Physical", "The user tears at the foe with blades formed by psychic power. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Razor Leaf", 55, 95, 25, (int)Enum.type.Grass, noEffect, "Physical", "A sharp-edged leaf is launched to slash at the foe. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Shadow Claw", 70, 100, 15, (int)Enum.type.Ghost, noEffect, "Physical", "The user slashes with a sharp claw made from shadows. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Slash", 70, 100, 20, (int)Enum.type.Normal, noEffect, "Physical", "The foe is attacked with a slash of claws, etc. It has a high critical-hit ratio.", true));
            moves.Add(new Move("Stone Edge", 100, 80, 5, (int)Enum.type.Rock, noEffect, "Physical", "The user stabs the foe with a sharpened stone. It has a high critical-hit ratio.", true));

            //Meteo
            moves.Add(new Move("Rain Dance", 5, (int)Enum.type.Water, rain, "The user summons a heavy rain that falls for five turns, powering up Water-type moves."));           
            moves.Add(new Move("Sunny Day", 5, (int)Enum.type.Fire, sunny, "The user intensifies the sun for five turns, powering up Fire-type moves."));
            moves.Add(new Move("Sandstorm", 10, (int)Enum.type.Rock, sandstorm, "A five-turn sandstorm is summoned to hurt all combatant types except Rock, Ground, and Steel."));
            moves.Add(new Move("Hail", 10, (int)Enum.type.Ice, hail, "The user summons a hailstorm lasting five turns. It damages all Pokémon except the Ice type."));

            //Burn Status
            moves.Add(new Move("Inferno", 100, 50, 5, (int)Enum.type.Fire, burn, "Special", "The user attacks by engulfing the target in an intense fire. This leaves the target with a burn."));
            moves.Add(new Move("Will-O-Wisp", 85, 15, (int)Enum.type.Fire, burn, "The user shoots a sinister, bluish white flame at the foe to inflict a burn."));
            moves.Add(new Move("Ember", 40, 100, 25, (int)Enum.type.Fire, burn10, "Special", "The foe is attacked with small flames. The target may also be left with a burn."));
            moves.Add(new Move("Fire Blast", 110, 85, 5, (int)Enum.type.Fire, burn10, "Special", "The foe is attacked with an intense blast of all-consuming fire. It may also leave the target with a burn."));            
            moves.Add(new Move("Fire Punch", 75, 100, 15, (int)Enum.type.Fire, burn10, "Physical", "The foe is punched with a fiery fist. It may leave the target with a burn."));
            moves.Add(new Move("Flame Wheel", 60, 100, 25, (int)Enum.type.Fire, burn10, "Physical", "The user cloaks itself in fire and charges at the foe. It may also leave the target with a burn."));
            moves.Add(new Move("Flamethrower", 90, 100, 15, (int)Enum.type.Fire, burn10, "Special", "The foe is scorched with an intense blast of fire. The target may also be left with a burn."));
            moves.Add(new Move("Heat Wave", 95, 90, 10, (int)Enum.type.Fire, burn10, "Special", "The foe is scorched with an intense blast of fire. The target may also be left with a burn."));
            moves.Add(new Move("Lava Plume", 80, 100, 15, (int)Enum.type.Fire, burn30, "Special", "An inferno of scarlet flames washes over all Pokémon in battle. It may also inflict burns."));
            moves.Add(new Move("Scald", 80, 100, 15, (int)Enum.type.Water, burn30, "Special", "The user shoots boiling hot water at its target. This may also leave the target with a burn."));
            moves.Add(new Move("Sacred Fire", 100, 95, 5, (int)Enum.type.Fire, burn50, "Special", "The foe is razed with a mystical fire of great intensity. It may also leave the target with a burn."));

            //Paralysis Status
            moves.Add(new Move("Glare", 100, 30, (int)Enum.type.Normal, paralysis, "The user intimidates the foe with the pattern on its belly to cause paralysis."));
            moves.Add(new Move("Nuzzle", 20, 100, 20, (int)Enum.type.Electric, paralysis, "Physical", "The user attacks by nuzzling its electrified cheeks against the target. This also leaves the target with paralysis."));
            moves.Add(new Move("Stun Spore", 75, 30, (int)Enum.type.Grass, paralysis, "The user scatters a cloud of paralyzing powder. It may paralyze the target."));
            moves.Add(new Move("Thunder Wave", 90, 20, (int)Enum.type.Electric, paralysis, "A weak electric charge is launched at the foe. It causes paralysis if it hits."));
            moves.Add(new Move("Zap Cannon", 120, 50, 5, (int)Enum.type.Electric, paralysis, "Special", "The user fires an electric blast like a cannon to inflict damage and cause paralysis."));
            moves.Add(new Move("Thunder Punch", 75, 100, 15, (int)Enum.type.Electric, paralysis10, "Physical", "The foe is punched with an electrified fist. It may leave the target with paralysis."));
            moves.Add(new Move("Thunder Shock", 40, 100, 30, (int)Enum.type.Electric, paralysis10, "Special", "A jolt of electricity is hurled at the foe to inflict damage. It may also leave the foe paralyzed."));
            moves.Add(new Move("Thunderbolt", 90, 100, 15, (int)Enum.type.Electric, paralysis10, "Special", "A strong electric blast is loosed at the foe. It may also leave the foe paralyzed."));
            moves.Add(new Move("Body Slam", 85, 100, 15, (int)Enum.type.Normal, paralysis30, "Physical", "The user drops onto the foe with its full body weight. It may leave the foe paralyzed."));
            moves.Add(new Move("Bounce", 95, 85, 5, (int)Enum.type.Fly, paralysis30, "Physical", "The user bounces up high, then drops on the foe on the second turn. It may also paralyze the foe."));
            moves.Add(new Move("Discharge", 80, 100, 15, (int)Enum.type.Electric, paralysis30, "Special", "A flare of electricity is loosed to strike all Pokémon in battle. It may also cause paralysis."));
            moves.Add(new Move("Dragon Breath", 60, 100, 20, (int)Enum.type.Dragon, paralysis30, "Special", "The user exhales a mighty gust that inflicts damage. It may also paralyze the target."));
            moves.Add(new Move("Force Palm", 60, 100, 10, (int)Enum.type.Fighting, paralysis30, "Physical", "The foe is attacked with a shock wave. It may also leave the target paralyzed."));
            moves.Add(new Move("Lick", 30, 100, 30, (int)Enum.type.Ghost, paralysis30, "Physical", "The foe is licked with a long tongue, causing damage. It may also paralyze the target."));
            moves.Add(new Move("Spark", 65, 100, 20, (int)Enum.type.Electric, paralysis30, "Physical", "The user throws an electrically charged tackle at the foe. It may also leave the target paralyzed."));
            moves.Add(new Move("Thunder", 110, 70, 10, (int)Enum.type.Electric, paralysis30, "Special", "A wicked thunderbolt is dropped on the foe to inflict damage. It may also leave the target paralyzed."));
            
            //Poison Status
            moves.Add(new Move("Poison Powder", 75, 35, (int)Enum.type.Poison, poison, "A cloud of poisonous dust is scattered on the foe. It may poison the target."));
            moves.Add(new Move("Sludge Wave", 95, 100, 10, (int)Enum.type.Poison, poison10, "Special", "The user strikes everything around it by swamping the area with a giant sludge wave. This may also poison those hit."));
            moves.Add(new Move("Sludge Bomb", 90, 100, 10, (int)Enum.type.Poison, poison30, "Special", "The user attacks by hurling filthy sludge at the foe. It may also poison the target."));
            moves.Add(new Move("Toxic", 90, 10, (int)Enum.type.Poison, badlyPoison, "A move that leaves the target badly poisoned. Its poison damage worsens every turn."));
            moves.Add(new Move("Cross Poison", 70, 100, 20, (int)Enum.type.Poison, crossPoison, "Physical", "A slashing attack that may also leave the target poisoned. It has a high critical-hit ratio.", true));

            //Freeze Status
            moves.Add(new Move("Blizzard", 110, 70, 5, (int)Enum.type.Ice, freeze10, "Special", "A howling blizzard is summoned to strike the foe. It may also freeze the target solid."));
            moves.Add(new Move("Ice Beam", 90, 100, 10, (int)Enum.type.Ice, freeze10, "Special", "The foe is struck with an icy-cold beam of energy. It may also freeze the target solid."));
            moves.Add(new Move("Ice Punch", 90, 100, 15, (int)Enum.type.Ice, freeze10, "Physical", "The foe is punched with an icy fist. It may leave the target frozen."));
            moves.Add(new Move("Powder Snow", 40, 100, 25, (int)Enum.type.Ice, freeze10, "Special", "The user attacks with a chilling gust of powdery snow. It may also freeze the target."));

            //Sleep Status
            moves.Add(new Move("Grass Whistle", 55, 15, (int)Enum.type.Grass, sleep, "The user plays a pleasant melody that lulls the foe into a deep sleep."));
            moves.Add(new Move("Hypnosis", 60, 20, (int)Enum.type.Psy, sleep, "The user employs hypnotic suggestion to make the target fall into a deep sleep."));
            moves.Add(new Move("Spore", 100, 15, (int)Enum.type.Grass, sleep, "The user scatters bursts of spores that induce sleep."));
            moves.Add(new Move("Lovely Kiss", 75, 10, (int)Enum.type.Normal, sleep, "With a scary face, the user forces a kiss on the foe. It may make the target fall asleep."));
            moves.Add(new Move("Sing", 55, 15, (int)Enum.type.Normal, sleep, "A soothing lullaby is sung in a calming voice that puts the foe into a deep slumber."));
            moves.Add(new Move("Sleep Powder", 75, 15, (int)Enum.type.Grass, sleep, "The user scatters a big cloud of sleep-inducing dust around the foe."));
            moves.Add(new Move("Yawn", 100, 10, (int)Enum.type.Normal, yawn, "The user lets loose a huge yawn that lulls the foe into falling asleep on the next turn."));

            //Confusion Status
            moves.Add(new Move("Confusion", 50, 100, 25, (int)Enum.type.Psy, confusion10, "Special", "The foe is hit by a weak telekinetic force. It may also leave the foe confused."));
            moves.Add(new Move("Dizzy Punch", 70, 100, 10, (int)Enum.type.Normal, confusion20, "Physical", "The foe is hit with a rhythmically launched punch that may also leave it confused."));
            moves.Add(new Move("Dynamic Punch", 100, 50, 5, (int)Enum.type.Fighting, confusion, "Physical", "The foe is punched with the user’s full, concentrated power. It confuses the foe if it hits."));
            moves.Add(new Move("Psybeam", 65, 100, 20, (int)Enum.type.Psy, confusion10, "Special", "The foe is attacked with a peculiar ray. It may also leave the target confused."));
            moves.Add(new Move("Rock Climb", 90, 85, 20, (int)Enum.type.Ground, confusion20, "Physical", "A charging attack that may also leave the foe confused."));
            moves.Add(new Move("Signal Beam", 75, 100, 15, (int)Enum.type.Bug, confusion10, "Special", "The user attacks with a sinister beam of light. It may also confuse the target."));
            moves.Add(new Move("Water Pulse", 60, 100, 20, (int)Enum.type.Water, confusion20, "Special", "The user attacks the foe with a pulsing blast of water. It may also confuse the foe."));
            moves.Add(new Move("Confuse Ray", 100, 10, (int)Enum.type.Ghost, confusion, "The foe is exposed to a sinister ray that triggers confusion."));
            moves.Add(new Move("Supersonic", 55, 20, (int)Enum.type.Normal, confusion, "The user generates odd sound waves from its body. It may confuse the target."));
            moves.Add(new Move("Sweet Kiss", 75, 10, (int)Enum.type.Fairy, confusion, "The user kisses the foe with a sweet, angelic cuteness that causes confusion."));
            moves.Add(new Move("Teeter Dance", 100, 20, (int)Enum.type.Normal, confusion, "The user performs a wobbly dance that causes confusion."));

            //Secondary Effect
            moves.Add(new Move("Block", 5, (int)Enum.type.Normal, block, "The user blocks the foe’s way with arms spread wide to prevent escape."));
            moves.Add(new Move("Mean Look", 5, (int)Enum.type.Normal, block, "The user affixes the foe with a dark, arresting look. The target becomes unable to flee."));
            moves.Add(new Move("Spider Web", 10, (int)Enum.type.Bug, block, "The user ensnares the foe with a thin, gooey silk so it can’t flee from battle."));          
            moves.Add(new Move("Attract", 100, 15, (int)Enum.type.Normal, attract, "If it is the opposite gender of the user, the foe becomes infatuated and less likely to attack."));
            moves.Add(new Move("Leech Seed", 90, 10, (int)Enum.type.Grass, leechSeed, 100, "A seed is planted on the foe. It steals some HP from the foe to heal the user on every turn."));
            moves.Add(new Move("Torment", 100, 15, (int)Enum.type.Dark, torment, "The user torments and enrages the foe, making it incapable of using the same move twice in a row."));
            moves.Add(new Move("Taunt", 100, 20, (int)Enum.type.Dark, taunt, "The foe is taunted into a rage that allows it to use only attack moves for two to four turns."));

            //Protect and stuff
            moves.Add(new Move("Endure", 10, (int)Enum.type.Normal, endure, 4, "The user endures any attack, leaving 1 HP. Its chance of failing rises if it is used in succession."));
            moves.Add(new Move("Protect", 10, (int)Enum.type.Normal, protect, 4, "It enables the user to evade all attacks. Its chance of failing rises if it is used in succession."));
            moves.Add(new Move("Light Screen", 5, (int)Enum.type.Psy, lightScreen, "A wondrous wall of light is put up to suppress damage from special attacks for five turns."));
            moves.Add(new Move("Reflect", 5, (int)Enum.type.Psy, reflect, "A wondrous wall of light is put up to suppress damage from physical attacks for five turns."));

            //Moves that cannot miss
            moves.Add(new Move("Aerial Ace", 60,  20, (int)Enum.type.Fly, noEffect, "Physical", "The user confounds the foe with speed, then slashes. The attack lands without fail."));
            moves.Add(new Move("Aura Sphere", 80,  20, (int)Enum.type.Fighting, noEffect, "Special", "The user looses a blast of aura power from deep within its body. This move is certain to hit."));
            moves.Add(new Move("Disarming Voice", 40,  15, (int)Enum.type.Fairy, noEffect, "Special", "Letting out a charming cry, the user does emotional damage to opposing Pokémon. This attack never misses."));
            moves.Add(new Move("Feint Attack", 60,  20, (int)Enum.type.Dark, noEffect, "Physical", "The user draws up to the foe disarmingly, then throws a sucker punch. It hits without fail."));
            moves.Add(new Move("Magical Leaf", 60,  20, (int)Enum.type.Grass, noEffect, "Special", "The user scatters curious leaves that chase the foe. This attack will not miss."));
            moves.Add(new Move("Magnet Bomb", 60,  20, (int)Enum.type.Steel, noEffect, "Physical", "The user launches a steel bomb that sticks to the target. This attack will not miss."));
            moves.Add(new Move("Shadow Punch", 60,  20, (int)Enum.type.Ghost, noEffect, "Physical", "The user throws a punch at the foe from the shadows. The punch lands without fail."));
            moves.Add(new Move("Shock Wave", 60,  20, (int)Enum.type.Electric, noEffect, "Special", "The user strikes the foe with a quick jolt of electricity. This attack cannot be evaded."));
            moves.Add(new Move("Swift", 60,  20, (int)Enum.type.Normal, noEffect, "Special", "Star-shaped rays are shot at the foe. This attack never misses."));
            moves.Add(new Move("Vital Throw", 70,  10, (int)Enum.type.Fighting, noEffect, "Physical", -1, "The user allows the foe to attack first. In return, this throw move is guaranteed not to miss."));
            moves.Add(new Move("Smart Strike", 70,  10, (int)Enum.type.Steel, noEffect, "Physical", "The user stabs the target with a sharp horn. This attack never misses."));

            //Moves that cause the defending pokemon to flinch
            moves.Add(new Move("Extrasensory", 80, 100, 20, (int)Enum.type.Psy, flinch10, "Special", "The user attacks with an odd, unseeable power. It may also make the foe flinch."));
            moves.Add(new Move("Hyper Fang", 80, 90, 15, (int)Enum.type.Normal, flinch10, "Physical", "The user bites hard on the foe with its sharp front fangs. It may also make the target flinch."));
            moves.Add(new Move("Dark Pulse", 80, 100, 15, (int)Enum.type.Dark, flinch20, "Special", "The user releases a horrible aura imbued with dark thoughts. It may also make the target flinch."));
            moves.Add(new Move("Dragon Rush", 100, 75, 10, (int)Enum.type.Dragon, flinch20, "Physical", "The user tackles the foe while exhibiting overwhelming menace. It may also make the target flinch."));
            moves.Add(new Move("Waterfall", 80, 100, 15, (int)Enum.type.Water, flinch20, "Physical", "The user charges the foe at an awesome speed. It can also be used to climb a waterfall."));
            moves.Add(new Move("Zen Headbutt", 80, 90, 15, (int)Enum.type.Psy, flinch20, "Physical", "The user focuses its willpower to its head and rams the foe. It may also make the target flinch."));
            moves.Add(new Move("Stomp", 65, 100, 20, (int)Enum.type.Normal, flinch30, "Physical", "The foe is stomped with a big foot. It may also make the target flinch."));
            moves.Add(new Move("Rock Slide", 75, 90, 10, (int)Enum.type.Rock, flinch30, "Physical", "Large boulders are hurled at the foe to inflict damage. It may also make the target flinch."));
            moves.Add(new Move("Iron Head", 80, 100, 15, (int)Enum.type.Steel, flinch30, "Physical", "The foe slams the target with its steel-hard head. It may also make the target flinch."));
            moves.Add(new Move("Headbutt", 70, 100, 15, (int)Enum.type.Normal, flinch30, "Physical", "The user sticks its head out and rams straight forward. It may make the foe flinch."));
            moves.Add(new Move("Bite", 60, 100, 25, (int)Enum.type.Dark, flinch30, "Physical", "The foe is bitten with viciously sharp fangs. It may make the target flinch."));
            moves.Add(new Move("Astonish", 30, 100, 15, (int)Enum.type.Ghost, flinch30, "Physical", "The user attacks the foe while shouting in a startling fashion. It may also make the target flinch."));
            moves.Add(new Move("Air Slash", 75, 95, 15, (int)Enum.type.Fly, flinch30, "Special", "The user attacks with a blade of air that slices even the sky. It may also make the target flinch."));
            moves.Add(new Move("Twister", 40, 100, 20, (int)Enum.type.Dragon, flinch30, "Special", "The user whips up a vicious twister to tear at the foe. It may also make the foe flinch."));

            //Moves that cause a recoil
            moves.Add(new Move("Brave Bird", 120, 100, 15, (int)Enum.type.Fly, recoilThree, "Physical", "The user tucks in its wings and charges from a low altitude. The user also takes serious damage."));
            moves.Add(new Move("Double-Edge", 120, 100, 15, (int)Enum.type.Normal, recoilThree, "Physical", "A reckless, life-risking tackle. It also damages the user by a fairly large amount, however."));
            moves.Add(new Move("Head Charge", 120, 100, 15, (int)Enum.type.Normal, recoilFour, "Physical", "The user charges its head into its target, using its powerful guard hair. It also damages the user a little."));
            moves.Add(new Move("Submission", 80, 80, 20, (int)Enum.type.Fighting, recoilFour, "Physical", "The user grabs the foe and recklessly dives for the ground. It also hurts the user slightly."));
            moves.Add(new Move("Take Down", 90, 85, 20, (int)Enum.type.Normal, recoilFour, "Physical", "A reckless, full-body charge attack for slamming into the foe. It also damages the user a little."));
            moves.Add(new Move("Wild Charge", 90, 100, 15, (int)Enum.type.Electric, recoilFour, "Physical", "The user shrouds itself in electricity and smashes into its target. It also damages the user a little."));

            //Moves that user must recharge next turn.
            moves.Add(new Move("Giga Impact", 150, 90, 5, (int)Enum.type.Normal, mustRecharge, "Physical", "The user charges at the foe using every bit of its power. The user must rest on the next turn."));
            moves.Add(new Move("Hyper Beam", 150, 90, 5, (int)Enum.type.Normal, mustRecharge, "Special", "The foe is attacked with a powerful beam. The user must rest on the next turn to regain its energy."));

            //Moves that has multiple hit
            moves.Add(new Move("Bullet Seed", 25, 100, 30, (int)Enum.type.Grass, bulletSeed, "Physical", "The user forcefully shoots seeds at the foe. Two to five seeds are shot in rapid succession."));
            moves.Add(new Move("Comet Punch", 18, 85, 15, (int)Enum.type.Normal, cometPunch, "Physical", "The foe is hit with a flurry of punches that strike two to five times in a row."));
            moves.Add(new Move("Fury Swipes", 18, 80, 15, (int)Enum.type.Normal, cometPunch, "Physical", "The foe is raked with sharp claws or scythes for two to five times in quick succession."));
            moves.Add(new Move("Icicle Spear", 25, 100, 30, (int)Enum.type.Ice, icicle, "Physical", "The user launches sharp icicles at the foe. It strikes two to five times in a row."));
            moves.Add(new Move("Pin Missile", 25, 95, 20, (int)Enum.type.Bug, pin, "Physical", "Sharp pins are shot at the foe in rapid succession. They hit two to five times in a row."));
            moves.Add(new Move("Rock Blast", 25, 90, 10, (int)Enum.type.Rock, rockBlast, "Physical", "The user hurls hard rocks at the foe. Two to five rocks are launched in quick succession."));
            moves.Add(new Move("Scale Shot", 25, 90, 20, (int)Enum.type.Dragon, scaleShot, "Physical", "The user attacks by shooting scales two to five times in a row. This move boosts the user's Speed stat but lowers its Defense stat."));
            moves.Add(new Move("Spike Cannon", 20, 100, 15, (int)Enum.type.Normal, spikeCannon, "Physical", "Sharp spikes are fired at the foe to strike two to five times in rapid succession."));
            moves.Add(new Move("Tail Slap", 25, 85, 10, (int)Enum.type.Normal, tailSlap, "Physical", "The user attacks by striking the target with its hard tail. It hits the target two to five times in a row."));

            //Moves that attack for 2-3 turns and become confused
            moves.Add(new Move("Thrash", 120, 100, 10, (int)Enum.type.Normal, storm, "Physical", "The user rampages and attacks for two to three turns. It then becomes confused, however."));
            moves.Add(new Move("Petal Dance", 120, 100, 10, (int)Enum.type.Grass, storm, "Special", "The user attacks by scattering petals for two to three turns. The user then becomes confused."));
            moves.Add(new Move("Outrage", 120, 100, 10, (int)Enum.type.Dragon, storm, "Physical", "The user rampages and attacks for two to three turns. However, it then becomes confused."));

            //unique Moves
            moves.Add(new Move("Sucker Punch", 0, 100, 5, (int)Enum.type.Dark, suckerPunch, "Physical", 1, "This move enables the user to attack first. It fails if the foe is not readying an attack, however."));
            moves.Add(new Move("Haze", 30, (int)Enum.type.Ice, resetStat, 100, "The user creates a haze that eliminates every stat change among all the Pokémon engaged in battle."));
            moves.Add(new Move("Electro Ball", 0, 100, 10, (int)Enum.type.Electric, electroBall, "Special", "The user hurls an electric orb at the target. The faster the user is than the target, the greater the move's power."));
            moves.Add(new Move("Super Fang", 0, 90, 10, (int)Enum.type.Normal, superFang, "Physical", "The user chomps hard on the foe with its sharp front fangs. It cuts the target's HP to half."));            
            moves.Add(new Move("Dragon Rage", 0, 100, 10, (int)Enum.type.Dragon, dragonRage, "Special", "The foe is stricken by a shock wave. This attack always inflicts 40 HP damage."));
            moves.Add(new Move("Endeavor", 0, 100, 5, (int)Enum.type.Normal, endeavor, "Physical", "An attack move that cuts down the foe’s HP to equal the user’s HP."));
            moves.Add(new Move("Facade", 0, 100, 20, (int)Enum.type.Normal, facade, "Physical", "An attack move that doubles its power if the user is poisoned, paralyzed, or has a burn."));
            moves.Add(new Move("Brine", 0, 100, 10, (int)Enum.type.Water, brine, "Special", "If the foe’s HP is down to about half, this attack will hit with double the power."));
            moves.Add(new Move("Splash", 40, (int)Enum.type.Water, splash, "The user just flops and splashes around to no effect at all..."));
            moves.Add(new Move("Flail", 100, 15, (int)Enum.type.Normal, flail, "The user flails about aimlessly to attack. It becomes more powerful the less HP the user has."));
            moves.Add(new Move("Assurance", 0, 100, 10, (int)Enum.type.Dark, assurance, "Physical", "If the foe has already taken some damage in the same turn, this attack’s power is doubled."));
            moves.Add(new Move("Aromatherapy", 5, (int)Enum.type.Grass, aromatherapy, "The user releases a soothing scent that heals all status problems affecting the user’s party."));
            moves.Add(new Move("Grass Knot", 0, 100, 20, (int)Enum.type.Grass, grassKnot, "Special", "The user snares the foe with grass and trips it. The heavier the foe, the greater the damage."));
            moves.Add(new Move("Brick Break", 75, 100, 15, (int)Enum.type.Fighting, brickBreak, "Physical", "The user attacks with tough fists, etc. It can also break any barrier such as Light Screen and Reflect."));

            //Switching Moves
            //Effect forceSwitch = new Effect((int)Enum.effect.ForceSwitch);
            //moves.Add(new Move("Dragon Tail", 60, 90, 10, (int)Enum.type.Dragon, forceSwitch, 100, "Physical", "The user knocks away the target and drags out another Pokémon in its party. In the wild, the battle ends."));
            //moves.Add(new Move("Roar", 100, 10, (int)Enum.type.Normal, forceSwitch, 100, -6, "The foe is scared off, to be replaced by another Pokémon in its party. In the wild, the battle ends."));

            //Moves that has multiple effect
            moves.Add(new Move("Flare Blitz", 120, 100, 15, (int)Enum.type.Fire, flameBlitz, "Physical", "The user cloaks itself in fire and charges at the target. The user sustains serious damage and may leave the target burned."));
            moves.Add(new Move("Rest", 10, (int)Enum.type.Psy, rest, "The user goes to sleep for two turns. It fully restores the user's HP and heals any status problem."));
            moves.Add(new Move("Roost", 10, (int)Enum.type.Fly, roost, "The user lands and rests its body. It restores the user’s HP by up to half of its max HP."));

            //Multi Move that change stats
            moves.Add(new Move("Coil", 20, (int)Enum.type.Poison, coil, "The user coils up and concentrates. This raises its Attack and Defense stats as well as its accuracy."));
            moves.Add(new Move("Dragon Dance", 20, (int)Enum.type.Dragon, dragonDance, "The user vigorously performs a mystic, powerful dance that boosts its Attack and Speed stats."));
            moves.Add(new Move("Growth", 20, (int)Enum.type.Normal, growth, "The user’s body grows all at once, raising the Attack and Sp. Atk stats."));
            moves.Add(new Move("Work Up", 30, (int)Enum.type.Normal, workUp, "The user is roused, and its Attack and Sp. Atk stats increase."));
            moves.Add(new Move("Tickle", 100, 20, (int)Enum.type.Normal, tickle, "The user tickles the foe into laughing, reducing its Attack and Defense stats."));
            moves.Add(new Move("Hone Claws", 15, (int)Enum.type.Dark, honeClaws, "The user sharpens its claws to boost its Attack stat and accuracy."));
            moves.Add(new Move("Psych Up", 10, (int)Enum.type.Normal, psych, "The user hypnotizes itself into copying any stat change made by the foe."));
            moves.Add(new Move("Ancient Power", 60, 100, 5, (int)Enum.type.Rock, ancientPower, "Special", "The user attacks with a prehistoric power. It may also raise all the user’s stats at once."));
            moves.Add(new Move("Silver Wing", 60, 100, 5, (int)Enum.type.Bug, ancientPower, "Special", "The foe is attacked with powdery scales blown by wind. It may also raise all the user’s stats."));
            moves.Add(new Move("Superpower", 120, 100, 5, (int)Enum.type.Fighting, ancientPower, "Physical", "The user attacks the foe with great power. However, it also lowers the user’s Attack and Defense."));

            //Multi Moves with Status Problem
            moves.Add(new Move("Ice Fang", 65, 95, 15, (int)Enum.type.Ice, iceFang,"Physical", "The user bites with cold-infused fangs. It may also make the foe flinch or freeze."));
            moves.Add(new Move("Fire Fang", 65, 95, 15, (int)Enum.type.Fire, fireFang, "Physical", "The user bites with flame-cloaked fangs. It may also make the foe flinch or sustain a burn."));
            moves.Add(new Move("Thunder Fang", 65, 95, 15, (int)Enum.type.Electric, thunderFang, "Physical", "The user bites with electrified fangs. It may also make the foe flinch or become paralyzed."));
            
            //Multi Confusion
            moves.Add(new Move("Swagger", 85, 15, (int)Enum.type.Normal, swagger, "The user enrages the foe into confusion. However, it also sharply raises the foe's Attack stat."));
            moves.Add(new Move("Flatter", 100, 15, (int)Enum.type.Dark, flatter, "Flattery is used to confuse the foe. However, it also raises the target’s Sp. Atk stat."));

            //sorting by name
            moves = moves.OrderBy(q => q.Name).ToList();

            /*
            for (int i = 0; i < moves.Count; i++)
            {
                Console.WriteLine(moves[i].Name + ",");
            }           
            Console.ReadKey();
            */
            return moves;
        }
    }
}

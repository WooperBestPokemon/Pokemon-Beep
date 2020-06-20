using Pokemon_Beep.Battle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class MoveFactory
    {
        public List<Move> GetMoves()
        {
            List<Move> moves = new List<Move>();
            //Moves with no effect
            Effect noEffect = new Effect((int)Enum.effect.noEffect);
            moves.Add(new Move("Aqua Tail", 90, 90, 10, (int)Enum.type.Water, noEffect, "Physical"));
            moves.Add(new Move("Cut", 65, 100, 30, (int)Enum.type.Grass, noEffect, "Physical"));
            moves.Add(new Move("Dragon Claw", 80, 100, 15, (int)Enum.type.Dragon, noEffect, "Physical"));
            moves.Add(new Move("Dragon Pulse", 85, 100, 10, (int)Enum.type.Dragon, noEffect, "Special"));
            moves.Add(new Move("Drill Peck", 80, 100, 20, (int)Enum.type.Fly, noEffect, "Physical"));
            moves.Add(new Move("Egg Bomb", 100, 75, 10, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Fairy Wind", 40, 100, 30, (int)Enum.type.Fairy, noEffect, "Special"));
            moves.Add(new Move("Horn Attack", 65, 100, 25, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Hydro Pump", 110, 80, 5, (int)Enum.type.Water, noEffect, "Special"));
            moves.Add(new Move("Hyper Voice", 90, 100, 10, (int)Enum.type.Normal, noEffect, "Special"));
            moves.Add(new Move("Mega Kick", 120, 75, 5, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Mega Punch", 80, 85, 20, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Megahorn", 120, 85, 10, (int)Enum.type.Bug, noEffect, "Physical"));
            moves.Add(new Move("Peck", 35, 100, 35, (int)Enum.type.Fly, noEffect, "Physical"));
            moves.Add(new Move("Pound", 40, 100, 35, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Power Gem", 80, 100, 20, (int)Enum.type.Rock, noEffect, "Special"));
            moves.Add(new Move("Power Whip", 120, 85, 10, (int)Enum.type.Grass, noEffect, "Physical"));
            moves.Add(new Move("Rock Throw", 50, 90, 15, (int)Enum.type.Rock, noEffect, "Physical"));
            moves.Add(new Move("Scratch", 40, 100, 35, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Seed Bomb", 80, 100, 15, (int)Enum.type.Grass, noEffect, "Physical"));
            moves.Add(new Move("Slam", 80, 75, 20, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Strength", 80, 100, 15, (int)Enum.type.Fighting, noEffect, "Physical"));
            moves.Add(new Move("Tackle", 40, 100, 35, (int)Enum.type.Normal, noEffect, "Physical"));
            moves.Add(new Move("Vine Whip", 45, 100, 25, (int)Enum.type.Grass, noEffect, "Physical"));
            moves.Add(new Move("Water Gun", 40, 100, 25, (int)Enum.type.Water, noEffect, "Special"));
            moves.Add(new Move("Wing Attack", 60, 100, 35, (int)Enum.type.Fly, noEffect, "Physical"));
            //Move that lower attack by 1 stage
            Effect lowerAttack1Stage = new Effect((int)Enum.effect.lowerAttack);
            moves.Add(new Move("Growl", 100, 40, (int)Enum.type.Normal, lowerAttack1Stage));
            //Moves that lower attack by 2 stage
            Effect lowerAttack2Stage = new Effect((int)Enum.effect.lowerAttack,2);
            moves.Add(new Move("Charm", 100, 20, (int)Enum.type.Fairy, lowerAttack2Stage));
            moves.Add(new Move("Feather Dance", 100, 15, (int)Enum.type.Fly, lowerAttack2Stage));
            //Moves that may lower attack by 1 stage
            Effect mayLowerAttack1Stage = new Effect((int)Enum.effect.lowerAttack, 1, 10);
            moves.Add(new Move("Aurora Beam", 65, 100, 20, (int)Enum.type.Ice,mayLowerAttack1Stage, "Special"));
            moves.Add(new Move("Play Rough", 90, 90, 10, (int)Enum.type.Fairy, mayLowerAttack1Stage, "Physical"));
            //Moves that lower defence by 1 stage
            Effect lowerDefence1Stage = new Effect((int)Enum.effect.lowerDefense);
            moves.Add(new Move("Leer", 100, 30, (int)Enum.type.Normal, lowerDefence1Stage));
            moves.Add(new Move("Tail Whip", 100, 30, (int)Enum.type.Normal, lowerDefence1Stage));
            //Move that lower defence by 2 stage
            Effect screech = new Effect((int)Enum.effect.lowerDefense,2);
            moves.Add(new Move("Screech", 85, 40, (int)Enum.type.Normal, screech));
            //Moves that may lower defense by 1 stage
            Effect mayLowerDefence20 = new Effect((int)Enum.effect.lowerDefense, 1,20);
            moves.Add(new Move("Crunch", 80, 100, 15, (int)Enum.type.Dark, mayLowerDefence20, "Physical"));
            moves.Add(new Move("Liquidation", 85, 100, 10, (int)Enum.type.Water, mayLowerDefence20, "Physical"));
            Effect mayLowerDefence30 = new Effect((int)Enum.effect.lowerDefense, 1, 30);
            moves.Add(new Move("Iron Tail", 100, 75, 15, (int)Enum.type.Steel, mayLowerDefence30, "Physical"));
            Effect mayLowerDefence50 = new Effect((int)Enum.effect.lowerDefense, 1, 50);
            moves.Add(new Move("Crush Claw", 75, 95, 10, (int)Enum.type.Normal, mayLowerDefence50, "Physical"));
            moves.Add(new Move("Razor Shell", 75, 95, 10, (int)Enum.type.Water, mayLowerDefence50, "Physical"));
            //Moves that lower special attack
            Effect lowerSpecialAttack1Stage = new Effect((int)Enum.effect.lowerSpecialAttack);
            moves.Add(new Move("Confide", 100, 20, (int)Enum.type.Normal, lowerSpecialAttack1Stage));
            moves.Add(new Move("Mystical Fire", 75, 100, 10, (int)Enum.type.Fire, lowerSpecialAttack1Stage, "Special"));
            moves.Add(new Move("Snarl", 55, 95, 15, (int)Enum.type.Dark, lowerSpecialAttack1Stage, "Special"));
            moves.Add(new Move("Struggle Bug", 50, 100, 20, (int)Enum.type.Bug, lowerSpecialAttack1Stage, "Special"));
            //Moves that lower special attack by 2 stages
            Effect lowerSpecialAttack2Stage = new Effect((int)Enum.effect.lowerSpecialAttack,2);
            moves.Add(new Move("Eerie Impulse", 100, 15, (int)Enum.type.Electric, lowerSpecialAttack2Stage));
            //Moves that may lower special attack
            Effect mayLowerSpecialAttack = new Effect((int)Enum.effect.lowerSpecialAttack,1,30);
            moves.Add(new Move("Moonblast", 95, 100, 15, (int)Enum.type.Fairy, mayLowerSpecialAttack, "Special"));
            //Moves that lower special defence by 2 stages
            Effect lowerSpecialDefense = new Effect((int)Enum.effect.lowerSpecialDefense, 2);
            moves.Add(new Move("Acid Spray", 40, 100, 20, (int)Enum.type.Poison, lowerSpecialDefense, "Special"));
            moves.Add(new Move("Fake Tears", 100, 20, (int)Enum.type.Dark, lowerSpecialDefense));
            moves.Add(new Move("Metal Sound", 85, 40, (int)Enum.type.Steel, lowerSpecialDefense));
            //Moves that may lower special defence
            Effect mayLowerSpecialDefense10 = new Effect((int)Enum.effect.lowerSpecialDefense, 1, 10);
            moves.Add(new Move("Acid", 40, 100, 30, (int)Enum.type.Poison, mayLowerSpecialDefense10, "Special"));
            moves.Add(new Move("Bug Buzz", 90, 100, 10, (int)Enum.type.Bug, mayLowerSpecialDefense10, "Special"));
            moves.Add(new Move("Earth Power", 90, 100, 10, (int)Enum.type.Ground, mayLowerSpecialDefense10, "Special"));
            moves.Add(new Move("Energy Ball", 90, 100, 10, (int)Enum.type.Grass, mayLowerSpecialDefense10, "Special"));
            moves.Add(new Move("Flash Cannon", 80, 100, 10, (int)Enum.type.Steel, mayLowerSpecialDefense10, "Special"));
            moves.Add(new Move("Focus Blast", 120, 70, 5, (int)Enum.type.Fighting, mayLowerSpecialDefense10, "Special"));
            moves.Add(new Move("Psychic", 90, 100, 10, (int)Enum.type.Psy, mayLowerSpecialDefense10, "Special"));
            Effect mayLowerSpecialDefense20 = new Effect((int)Enum.effect.lowerSpecialDefense, 1, 20);
            moves.Add(new Move("Shadow Ball", 80, 100, 15, (int)Enum.type.Ghost, mayLowerSpecialDefense20, "Special"));
            //Moves that lower Speed by 1 stage
            Effect lowerSpeed = new Effect((int)Enum.effect.lowerSpeed);
            moves.Add(new Move("Icy Wind", 55, 95, 15, (int)Enum.type.Ice, lowerSpeed, "Special"));
            moves.Add(new Move("Mud Shot", 55, 95, 15, (int)Enum.type.Ground, lowerSpeed, "Special"));
            moves.Add(new Move("Rock Tomb", 60, 95, 15, (int)Enum.type.Rock, lowerSpeed, "Physical"));
            //Moves that lower Speed by 2 stages
            Effect lowerSpeed2Stage = new Effect((int)Enum.effect.lowerSpeed,2);
            moves.Add(new Move("Cotton Spore", 100, 40, (int)Enum.type.Grass, lowerSpeed2Stage));
            moves.Add(new Move("Scary Face", 100, 10, (int)Enum.type.Normal, lowerSpeed2Stage));
            moves.Add(new Move("String Shot", 95, 40, (int)Enum.type.Bug, lowerSpeed2Stage));
            //Move that raise Attack
            Effect raiseAttack = new Effect((int)Enum.effect.increaseAttack);
            moves.Add(new Move("Meditate", 100, 40, (int)Enum.type.Psy, raiseAttack));
            moves.Add(new Move("Sharpen", 100, 30, (int)Enum.type.Normal, raiseAttack));

            //Meteo
            Effect rain = new Effect((int)Enum.effect.rain);
            moves.Add(new Move("Rain Dance", 100, 5, (int)Enum.type.Water, rain));

            //sorting by name
            moves = moves.OrderBy(q => q.Name).ToList();
            return moves;
        }
    }
}

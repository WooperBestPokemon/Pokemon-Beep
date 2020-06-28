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

            //Move with priority
            moves.Add(new Move("Quick Attack", 40, 100, 30, (int)Enum.type.Normal, noEffect, "Physical"));

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
            //Moves that raise Attack
            Effect raiseAttack = new Effect((int)Enum.effect.increaseAttack);
            moves.Add(new Move("Meditate", 100, 40, (int)Enum.type.Psy, raiseAttack));
            moves.Add(new Move("Sharpen", 100, 30, (int)Enum.type.Normal, raiseAttack));
            Effect raiseAttack2Stage = new Effect((int)Enum.effect.increaseAttack, 2);
            moves.Add(new Move("Swords Dance", 100, 20, (int)Enum.type.Normal, raiseAttack2Stage));
            //Moves that raise Defense
            Effect raiseDefense = new Effect((int)Enum.effect.increaseDefense);
            moves.Add(new Move("Defense Curl", 100, 40, (int)Enum.type.Normal, raiseDefense));
            moves.Add(new Move("Harden", 100, 30, (int)Enum.type.Normal, raiseDefense));
            moves.Add(new Move("Withdraw", 100, 40, (int)Enum.type.Water, raiseDefense));
            Effect raiseDefense2Stage = new Effect((int)Enum.effect.increaseDefense,2);
            moves.Add(new Move("Acid Armor", 100, 20, (int)Enum.type.Poison, raiseDefense2Stage));
            moves.Add(new Move("Barrier", 100, 20, (int)Enum.type.Psy, raiseDefense2Stage));
            moves.Add(new Move("Iron Defense", 100, 15, (int)Enum.type.Steel, raiseDefense2Stage));
            Effect raiseDefense3Stage = new Effect((int)Enum.effect.increaseDefense, 3);
            moves.Add(new Move("Cotton Guard", 100, 10, (int)Enum.type.Grass, raiseDefense3Stage));
            //Moves that raise Special Attack
            Effect mayRaiseSpecialAttack70 = new Effect((int)Enum.effect.increaseSpecialAttack,1,70);
            moves.Add(new Move("Charge Beam", 50, 90, 10, (int)Enum.type.Electric, mayRaiseSpecialAttack70, "Special"));
            Effect raiseSpecialAttack2Stage = new Effect((int)Enum.effect.increaseSpecialAttack, 2);
            moves.Add(new Move("Nasty Plot", 100, 20, (int)Enum.type.Dark, raiseSpecialAttack2Stage));
            //Move thar raise Special Defense
            Effect raiseSpecialDefense2Stage = new Effect((int)Enum.effect.increaseSpecialDefense, 2);
            moves.Add(new Move("Amnesia", 100, 20, (int)Enum.type.Psy, raiseSpecialAttack2Stage));
            //Move thar raise Speed
            Effect raiseSpeed = new Effect((int)Enum.effect.increaseSpeed);
            moves.Add(new Move("Flame Charge", 50, 100, 20, (int)Enum.type.Fire, raiseSpeed, "Physical"));
            Effect raiseSpeed2Stage = new Effect((int)Enum.effect.increaseSpeed, 2);
            moves.Add(new Move("Agility", 100, 30, (int)Enum.type.Psy, raiseSpeed2Stage));
            moves.Add(new Move("Rock Polish", 100, 20, (int)Enum.type.Rock, raiseSpeed2Stage));
            //Meteo
            Effect rain = new Effect((int)Enum.effect.rain);
            moves.Add(new Move("Rain Dance", 100, 5, (int)Enum.type.Water, rain));
            Effect sunny = new Effect((int)Enum.effect.sunny);
            moves.Add(new Move("Sunny Day", 100, 5, (int)Enum.type.Fire, sunny));
            Effect sandstorm = new Effect((int)Enum.effect.sandstorm);
            moves.Add(new Move("Sandstorm", 100, 10, (int)Enum.type.Rock, sandstorm));
            Effect snow = new Effect((int)Enum.effect.snow);
            moves.Add(new Move("Hail", 100, 10, (int)Enum.type.Ice, snow));

            //Burn Status
            Effect burn = new Effect((int)Enum.effect.burn);
            moves.Add(new Move("Inferno", 100, 50, 5, (int)Enum.type.Fire, burn, "Special"));
            moves.Add(new Move("Will-O-Wisp", 85, 15, (int)Enum.type.Fire, burn));
            Effect mayBurn = new Effect((int)Enum.effect.burn,1,10);
            moves.Add(new Move("Ember", 40, 100, 25, (int)Enum.type.Fire, mayBurn, "Special"));
            moves.Add(new Move("Fire Blast", 110, 85, 5, (int)Enum.type.Fire, mayBurn, "Special"));
            moves.Add(new Move("Fire Fang", 65, 95, 15, (int)Enum.type.Fire, mayBurn, "Physical"));
            moves.Add(new Move("Fire Punch", 75, 100, 15, (int)Enum.type.Fire, mayBurn, "Physical"));
            moves.Add(new Move("Flame Wheel", 60, 100, 25, (int)Enum.type.Fire, mayBurn, "Physical"));
            moves.Add(new Move("Flamethrower", 90, 100, 15, (int)Enum.type.Fire, mayBurn, "Special"));
            moves.Add(new Move("Heat Wave", 95, 90, 10, (int)Enum.type.Fire, mayBurn, "Special"));
            Effect mayBurn30 = new Effect((int)Enum.effect.burn, 1, 30);
            moves.Add(new Move("Lava Plume", 80, 100, 15, (int)Enum.type.Fire, mayBurn30, "Special"));
            moves.Add(new Move("Scald", 80, 100, 15, (int)Enum.type.Water, mayBurn30, "Special"));
            Effect mayBurn50 = new Effect((int)Enum.effect.burn, 1, 50);
            moves.Add(new Move("Sacred Fire", 100, 95, 5, (int)Enum.type.Fire, mayBurn50, "Special"));

            //Paralysis Status
            Effect paralysis = new Effect((int)Enum.effect.paralysis);
            moves.Add(new Move("Glare", 100, 30, (int)Enum.type.Normal, paralysis));
            moves.Add(new Move("Nuzzle", 20, 100, 20, (int)Enum.type.Electric, paralysis, "Physical"));
            moves.Add(new Move("Stun Spore", 75, 30, (int)Enum.type.Grass, paralysis));
            moves.Add(new Move("Thunder Wave", 90, 20, (int)Enum.type.Electric, paralysis));
            moves.Add(new Move("Zap Cannon", 120, 50, 5, (int)Enum.type.Electric, paralysis, "Special"));
            Effect mayParalyze = new Effect((int)Enum.effect.paralysis, 1, 10);
            moves.Add(new Move("Thunder Punch", 75, 100, 15, (int)Enum.type.Electric, mayParalyze, "Physical"));
            moves.Add(new Move("Thunder Shock", 40, 100, 30, (int)Enum.type.Electric, mayParalyze, "Special"));
            moves.Add(new Move("Thunderbold", 90, 100, 15, (int)Enum.type.Electric, mayParalyze, "Special"));
            Effect mayParalyze30 = new Effect((int)Enum.effect.paralysis, 1, 30);
            moves.Add(new Move("Body Slam", 85, 100, 15, (int)Enum.type.Normal, mayParalyze30, "Physical"));
            moves.Add(new Move("Bounce", 95, 85, 5, (int)Enum.type.Fly, mayParalyze30, "Physical"));
            moves.Add(new Move("Discharge", 80, 100, 15, (int)Enum.type.Electric, mayParalyze30, "Special"));
            moves.Add(new Move("Dragon Breath", 60, 100, 20, (int)Enum.type.Dragon, mayParalyze30, "Special"));
            moves.Add(new Move("Force Palm", 60, 100, 10, (int)Enum.type.Fighting, mayParalyze30, "Physical"));
            moves.Add(new Move("Lick", 30, 100, 30, (int)Enum.type.Ghost, mayParalyze30, "Physical"));
            moves.Add(new Move("Spark", 65, 100, 20, (int)Enum.type.Electric, mayParalyze30, "Physical"));
            moves.Add(new Move("Thunder", 110, 70, 10, (int)Enum.type.Electric, mayParalyze30, "Special"));            
            //Poison Status
            Effect poison = new Effect((int)Enum.effect.poison);
            moves.Add(new Move("Poison Powder", 75, 35, (int)Enum.type.Poison, poison));
            Effect strongPoison = new Effect((int)Enum.effect.poison,2);
            moves.Add(new Move("Toxic", 90, 10, (int)Enum.type.Poison, strongPoison));
            Effect mayPoison = new Effect((int)Enum.effect.poison, 1, 10);
            moves.Add(new Move("Sludge Wave", 95, 100, 10, (int)Enum.type.Poison, mayPoison, "Special"));
            Effect mayPoison30 = new Effect((int)Enum.effect.poison, 1, 30);
            moves.Add(new Move("Sludge Bomb", 90, 100, 10, (int)Enum.type.Poison, mayPoison30, "Special"));

            //Sleep Status
            Effect sleep = new Effect((int)Enum.effect.sleep);
            moves.Add(new Move("Grass Whistle", 55, 15, (int)Enum.type.Grass, sleep));
            moves.Add(new Move("Hypnosis", 60, 20, (int)Enum.type.Psy, sleep));
            moves.Add(new Move("Lovely Kiss", 75, 10, (int)Enum.type.Normal, sleep));
            moves.Add(new Move("Sing", 55, 15, (int)Enum.type.Normal, sleep));
            moves.Add(new Move("Sleep Powder", 75, 15, (int)Enum.type.Grass, sleep));
            Effect yawn = new Effect((int)Enum.effect.yawn);
            moves.Add(new Move("Yawn", 100, 10, (int)Enum.type.Normal, yawn));

            //Confusion Status
            Effect confusion = new Effect((int)Enum.effect.confusion);
            moves.Add(new Move("Sweet Kiss", 75, 10, (int)Enum.type.Fairy, confusion));

            //Defense
            Effect endure = new Effect((int)Enum.effect.endure);
            moves.Add(new Move("Endure", 100, 10, (int)Enum.type.Normal, endure, 4));
            Effect protect = new Effect((int)Enum.effect.protect);
            moves.Add(new Move("Protect", 100, 10, (int)Enum.type.Normal, protect, 4));
            moves.Add(new Move("Detect", 100, 5, (int)Enum.type.Fighting, protect, 4));

            //Moves that cannot miss ((400 is sure to never miss because 400 * 0.25 (6th stage of accuracy) = 100)
            moves.Add(new Move("Aerial Ace", 60, 400, 20, (int)Enum.type.Fly, noEffect, "Physical"));
            moves.Add(new Move("Aura Sphere", 80, 400, 20, (int)Enum.type.Fighting, noEffect, "Special"));
            moves.Add(new Move("Disarming Voice", 40, 400, 15, (int)Enum.type.Fairy, noEffect, "Special"));
            moves.Add(new Move("Feint Attack", 60, 400, 20, (int)Enum.type.Dark, noEffect, "Physical"));
            moves.Add(new Move("Magical Leaf", 60, 400, 20, (int)Enum.type.Grass, noEffect, "Special"));
            moves.Add(new Move("Magnet Bomb", 60, 400, 20, (int)Enum.type.Steel, noEffect, "Physical"));
            moves.Add(new Move("Shadow Punch", 60, 400, 20, (int)Enum.type.Ghost, noEffect, "Physical"));
            moves.Add(new Move("Shock Wave", 60, 400, 20, (int)Enum.type.Electric, noEffect, "Special"));
            moves.Add(new Move("Swift", 60, 400, 20, (int)Enum.type.Normal, noEffect, "Special"));
            moves.Add(new Move("Vital Throw", 70, 400, 10, (int)Enum.type.Fighting, noEffect, "Physical", -1));
            moves.Add(new Move("Smart Strike", 70, 400, 10, (int)Enum.type.Steel, noEffect, "Physical"));

            //Moves that cause the defending pokemon to flinch
            Effect mayFlinch = new Effect((int)Enum.effect.flinch,1,10);
            moves.Add(new Move("Hyper Fang", 80, 90, 15, (int)Enum.type.Normal, mayFlinch, "Physical"));
            //Other
            Effect resetStat = new Effect((int)Enum.effect.resetStat);
            moves.Add(new Move("Haze", 100, 30, (int)Enum.type.Ice, resetStat));
            Effect electroBall = new Effect((int)Enum.effect.electroBall);
            moves.Add(new Move("Electro Ball", 0, 100, 10, (int)Enum.type.Electric, electroBall, "Special"));
            Effect halvesHP = new Effect((int)Enum.effect.halvesHP);
            moves.Add(new Move("Super Fang", 0, 90, 10, (int)Enum.type.Normal, halvesHP, "Physical"));
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

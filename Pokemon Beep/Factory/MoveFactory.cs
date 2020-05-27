using Pokemon_Beep.Battle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class MoveFactory
    {
        private EffectFactory effectFactory = new EffectFactory();
        private List<Effect> effects;
        private enum effect
        {
            Null = 0,
        }
        private enum type
        {
            Normal = 1,
            Fire = 2,
            Water = 3,
            Electric = 4,
            Grass = 5,
            Ice = 6,
            Fighting = 7,
            Poison = 8,
            Ground = 9,
            Fly = 10,
            Psy = 11,
            Bug = 12,
            Rock = 13,
            Ghost = 14,
            Dragon = 15,
            Dark = 16,
            Steel = 17,
            Fairy = 18
        }
        public List<Move> GetMoves()
        {
            List<Move> moves = new List<Move>();
            effects = effectFactory.GetEffects();
            moves.Add(new Move("Water Gun", 40, 100, 25, (int)type.Water, effects[0], "Special"));
            moves.Add(new Move("Mud Shot", 55, 95, 15, (int)type.Ground, effects[3], "Special"));
            return moves;
        }
    }
}

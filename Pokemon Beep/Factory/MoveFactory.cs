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
        public List<Move> GetMoves()
        {
            List<Move> moves = new List<Move>();
            effects = effectFactory.GetEffects();
            //Wooper
            moves.Add(new Move("Water Gun", 40, 100, 25, (int)Enum.type.Water, effects[0], "Special"));
            moves.Add(new Move("Tail Whip", 100, 30, (int)Enum.type.Normal, effects[1]));
            //moves.Add(new Move("Mud Shot", 55, 95, 15, (int)type.Ground, effects[3], "Special"));
            //Other
            moves.Add(new Move("Pound", 40, 100, 35, (int)Enum.type.Normal, effects[0], "Physical"));
            return moves;
        }
    }
}

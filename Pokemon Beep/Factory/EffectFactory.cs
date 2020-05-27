using Pokemon_Beep.Battle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class EffectFactory
    {
        public List<Effect> GetEffects()
        {
            List<Effect> effects = new List<Effect>();
            effects.Add(new Effect(0, "Null"));
            effects.Add(new Effect(1, "Lower Attack 1"));
            effects.Add(new Effect(2, "Lower Defence 1"));
            effects.Add(new Effect(3, "Lower Speed 1"));
            effects.Add(new Effect(4, "Lower Accuracy 1"));
            effects.Add(new Effect(5, "Lower Spe Att 1"));
            effects.Add(new Effect(6, "Lower Spe Def 1"));
            return effects;
        }          
    }
}

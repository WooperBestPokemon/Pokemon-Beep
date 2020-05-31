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
            effects.Add(new Effect(1, "Lower Defence", 1));
            effects.Add(new Effect(3, "Lower Speed", 1));
            return effects;
        }          
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Combat
{
    /// <summary>
    /// This partial class job is to manage all the effects of the moves
    /// </summary>
    partial class Move
    {
        public void doEffect(PkmnBattleInfo attacker, PkmnBattleInfo defender)
        {
            //If the move has an effect
            if (Effects.Count != 0)
            {
                for (int i = 0; i < Effects.Count; i++)
                {
                    //Status
                    if (Effects[i].ID == (int)Enum.effect.Burn)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Burned;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Burned;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Burned;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Burned;
                            }
                        }
                        //TODO "The FoePokemonName was burned"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.Sleep)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Sleep;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Sleep;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Sleep;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Sleep;
                            }
                        }
                        //TODO "The FoePokemonName is asleep"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.Paralysis)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Paralyzed;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Paralyzed;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Paralyzed;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Paralyzed;
                            }
                        }
                        //TODO "The FoePokemonName is paralyzed"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.Freeze)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Frozen;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.Status = (int)Enum.status.Frozen;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Frozen;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.Status = (int)Enum.status.Frozen;
                            }
                        }
                        //TODO "The FoePokemonName is frozen"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.Poison)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (Effects[i].Multiplicator == 1)
                            {
                                if (EffectsChance.Count > 1)
                                {
                                    if (EffectsChance[i] >= random)
                                        attacker.Pokemon.Status = (int)Enum.status.Poisoned;
                                }
                                else
                                {
                                    if (EffectsChance[0] >= random)
                                        attacker.Pokemon.Status = (int)Enum.status.Poisoned;
                                }
                            }
                            else
                            {
                                if (EffectsChance.Count > 1)
                                {
                                    if (EffectsChance[i] >= random)
                                        attacker.Pokemon.Status = (int)Enum.status.Badly_Poisoned;
                                }
                                else
                                {
                                    if (EffectsChance[0] >= random)
                                        attacker.Pokemon.Status = (int)Enum.status.Badly_Poisoned;
                                }
                            }
                        }
                        else
                        {
                            if (Effects[i].Multiplicator == 1)
                            {
                                if (EffectsChance.Count > 1)
                                {
                                    if (EffectsChance[i] >= random)
                                        defender.Pokemon.Status = (int)Enum.status.Poisoned;
                                }
                                else
                                {
                                    if (EffectsChance[0] >= random)
                                        defender.Pokemon.Status = (int)Enum.status.Poisoned;
                                }
                            }
                            else
                            {
                                if (EffectsChance.Count > 1)
                                {
                                    if (EffectsChance[i] >= random)
                                        defender.Pokemon.Status = (int)Enum.status.Badly_Poisoned;
                                }
                                else
                                {
                                    if (EffectsChance[0] >= random)
                                        defender.Pokemon.Status = (int)Enum.status.Badly_Poisoned;
                                }
                            }
                            
                        }
                        //TODO "The FoePokemonName is frozen"
                    }
                    //Stats
                    else if (Effects[i].ID == (int)Enum.effect.LowerAttack)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Attack] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Attack] -= Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Attack] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Attack] -= Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.LowerDefense)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Defense] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Defense] -= Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Defense] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Defense] -= Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.LowerSpecialAttack)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.SpecialAttack] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.SpecialAttack] -= Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.SpecialAttack] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.SpecialAttack] -= Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.LowerSpecialDefense)
                    {
                        int random = Utilities.RandomNumber(1, 100);

                        if (EffectsChance.Count > 1)
                        {
                            if (EffectsChance[i] >= random)
                                defender.Pokemon.stages[(int)Enum.stat.SpecialDefense] -= Effects[i].Multiplicator;
                        }
                        else
                        {
                            if (EffectsChance[0] >= random)
                                defender.Pokemon.stages[(int)Enum.stat.SpecialDefense] -= Effects[i].Multiplicator;
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.LowerSpeed)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Speed] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Speed] -= Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Speed] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Speed] -= Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.LowerAccuracy)
                    {
                        int random = Utilities.RandomNumber(1, 100);

                        if(defender.Pokemon.Ability.Effect == (int)Enum.ability.Keen_Eye)
                        {
                            //TODO say something like : Keen Eye makes you unable to lower the accuracy
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Accuracy] -= Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Accuracy] -= Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's accuracy has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.LowerEvasion)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (EffectsChance.Count > 1)
                        {
                            if (EffectsChance[i] >= random)
                                defender.Pokemon.stages[(int)Enum.stat.Evasion] -= Effects[i].Multiplicator;
                        }
                        else
                        {
                            if (EffectsChance[0] >= random)
                                defender.Pokemon.stages[(int)Enum.stat.Evasion] -= Effects[i].Multiplicator;
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }

                    else if (Effects[i].ID == (int)Enum.effect.IncreaseAttack)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Attack] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Attack] += Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Attack] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Attack] += Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.IncreaseDefense)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Defense] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Defense] += Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Defense] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Defense] += Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.IncreaseSpecialAttack)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.SpecialAttack] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.SpecialAttack] += Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.SpecialAttack] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.SpecialAttack] += Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.IncreaseSpecialDefense)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.SpecialDefense] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.SpecialDefense] += Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.SpecialDefense] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.SpecialDefense] += Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.IncreaseSpeed)
                    {
                        int random = Utilities.RandomNumber(1, 100);

                        if (EffectsChance.Count > 1)
                        {
                            if (EffectsChance[i] >= random)
                                attacker.Pokemon.stages[(int)Enum.stat.Speed] += Effects[i].Multiplicator;
                        }
                        else
                        {
                            if (EffectsChance[0] >= random)
                                attacker.Pokemon.stages[(int)Enum.stat.Speed] += Effects[i].Multiplicator;
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.IncreaseAccuracy)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Accuracy] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Accuracy] += Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Accuracy] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Accuracy] += Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's accuracy has been lowered"
                    }
                    else if (Effects[i].ID == (int)Enum.effect.IncreaseEvasion)
                    {
                        int random = Utilities.RandomNumber(1, 100);
                        if (Effects[i].Self == true)
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Evasion] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    attacker.Pokemon.stages[(int)Enum.stat.Evasion] += Effects[i].Multiplicator;
                            }
                        }
                        else
                        {
                            if (EffectsChance.Count > 1)
                            {
                                if (EffectsChance[i] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Evasion] += Effects[i].Multiplicator;
                            }
                            else
                            {
                                if (EffectsChance[0] >= random)
                                    defender.Pokemon.stages[(int)Enum.stat.Evasion] += Effects[i].Multiplicator;
                            }
                        }
                        //TODO "The FoePokemonName's attack has been lowered"
                    }

                    //Other
                    else if (Effects[i].ID == (int)Enum.effect.Recoil)
                    {

                    }
                }
            }
        }
    }
}

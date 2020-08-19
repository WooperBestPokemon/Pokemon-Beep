using Pokemon_Beep.Combat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    /// <summary>
    /// Where all the Abilities are created
    /// </summary>
    class AbilityFactory
    {
        public List<Ability> GetAbilities()
        {
            List<Ability> abilities = new List<Ability>();

            abilities.Add(new Ability("Arena Trap", "Prevents the foe from fleeing.", (int)Enum.ability.Arena_Trap));
            abilities.Add(new Ability("Battle Armor", "The Pokémon is protected against critical hits.", (int)Enum.ability.Battle_Armor));
            abilities.Add(new Ability("Blaze", "Powers up Fire-type moves when health is below 1/3.", (int)Enum.ability.Blaze));
            abilities.Add(new Ability("Chlorophyll", "Boosts the Pokémon's Speed in sunshine.", (int)Enum.ability.Chlorophyll));
            abilities.Add(new Ability("Clear Body", "Prevents other Pokémon from lowering its stats.", (int)Enum.ability.Clear_Body));
            abilities.Add(new Ability("Cloud Nine", "Eliminates the effects of weather.", (int)Enum.ability.Cloud_Nine));
            abilities.Add(new Ability("Compound Eyes", "The Pokémon's accuracy is boosted.", (int)Enum.ability.Compound_Eyes));
            abilities.Add(new Ability("Cute Charm", "Contact with the Pokémon may cause infatuation.", (int)Enum.ability.Cute_Charm));
            abilities.Add(new Ability("Damp", "Prevents the use of self-destructing moves.", (int)Enum.ability.Damp));
            abilities.Add(new Ability("Drizzle", "The Pokémon makes it rain when it enters a battle.", (int)Enum.ability.Drizzle));
            abilities.Add(new Ability("Drought", "The Pokémon makes it sunny when it enters a battle.", (int)Enum.ability.Drought));
            abilities.Add(new Ability("Early Bird", "The Pokémon awakens quickly from sleep.", (int)Enum.ability.Early_Bird));
            abilities.Add(new Ability("Effect Spore", "Contact may poison or cause paralysis or sleep.", (int)Enum.ability.Effect_Spore));
            abilities.Add(new Ability("Flame Body", "Contact with the Pokémon may burn the attacker.", (int)Enum.ability.Flame_Body));
            abilities.Add(new Ability("Flash Fire", "It powers up Fire-type moves if it's hit by one.", (int)Enum.ability.Flash_Fire));
            abilities.Add(new Ability("Frisk", "The Pokémon can check the foe’s held item.", (int)Enum.ability.Frisk));
            abilities.Add(new Ability("Guts", "Boosts Attack if there is a status problem.", (int)Enum.ability.Guts));
            abilities.Add(new Ability("Huge Power", "Raises the Pokémon's Attack stat.", (int)Enum.ability.Huge_Power));
            abilities.Add(new Ability("Hustle", "Boosts the Attack stat, but lowers accuracy.", (int)Enum.ability.Hustle));
            abilities.Add(new Ability("Hyper Cutter", "Prevents other Pokémon from lowering Attack stat.", (int)Enum.ability.Hyper_Cutter));
            abilities.Add(new Ability("Immunity", "Prevents the Pokémon from getting poisoned.", (int)Enum.ability.Immunity));
            abilities.Add(new Ability("Inner Focus", "The Pokémon is protected from flinching.", (int)Enum.ability.Inner_Focus));
            abilities.Add(new Ability("Insomnia", "Prevents the Pokémon from falling asleep.", (int)Enum.ability.Insomnia));
            abilities.Add(new Ability("Intimidate", "Lowers the foe's Attack stat.", (int)Enum.ability.Intimidate));
            abilities.Add(new Ability("Keen_Eye", "Prevents other Pokémon from lowering accuracy.", (int)Enum.ability.Keen_Eye));
            abilities.Add(new Ability("Leaf Guard", "Prevents status conditions in harsh sunlight.", (int)Enum.ability.Leaf_Guard));
            abilities.Add(new Ability("Levitate", "Gives immunity to Ground type moves.", (int)Enum.ability.Levitate));
            abilities.Add(new Ability("Lightning Rod", "Draws in all Electric-type moves to up Sp. Attack.", (int)Enum.ability.Lightning_Rod));
            abilities.Add(new Ability("Limber", "The Pokémon is protected from paralysis.", (int)Enum.ability.Limber));
            abilities.Add(new Ability("Liquid Ooze", "Damages attackers using any draining move.", (int)Enum.ability.Liquid_Ooze));
            abilities.Add(new Ability("Magma Armor", "Prevents the Pokémon from becoming frozen.", (int)Enum.ability.Magma_Armor));
            abilities.Add(new Ability("Magnet Pull", "Prevents Steel-type Pokémon from escaping.", (int)Enum.ability.Magnet_Pull));
            abilities.Add(new Ability("Marvel Scale", "Ups Defense if there is a status problem.", (int)Enum.ability.Marvel_Scale));
            abilities.Add(new Ability("Minus", "Ups Sp. Atk if another Pokémon has Plus or Minus.", (int)Enum.ability.Minus));
            abilities.Add(new Ability("Natural Cure", "All status problems heal when it switches out.", (int)Enum.ability.Natural_Cure));
            abilities.Add(new Ability("Oblivious", "Prevents it from becoming infatuated.", (int)Enum.ability.Oblivious));
            abilities.Add(new Ability("Overgrow", "Powers up Grass-type moves in a pinch.", (int)Enum.ability.Overgrow));
            abilities.Add(new Ability("Own Tempo", "Prevents the Pokémon from becoming confused.", (int)Enum.ability.Own_Tempo));
            abilities.Add(new Ability("Pickup", "The Pokémon may pick up items.", (int)Enum.ability.Pickup));
            abilities.Add(new Ability("Plus", "Ups Sp. Atk if another Pokémon has Plus or Minus.", (int)Enum.ability.Plus));
            abilities.Add(new Ability("Poison Point", "Contact with the Pokémon may poison the attacker.", (int)Enum.ability.Poison_Point));
            abilities.Add(new Ability("Pressure", "The Pokémon raises the foe's PP usage.", (int)Enum.ability.Pressure));
            abilities.Add(new Ability("Pure Power", "Boosts the Pokémon’s Attack stat.", (int)Enum.ability.Pressure));
            abilities.Add(new Ability("Rain Dish", "Raises the Pokémon's Attack stat.", (int)Enum.ability.Rain_Dish));
            abilities.Add(new Ability("Rock_Head", "Protects the Pokémon from recoil damage.", (int)Enum.ability.Rock_Head));
            abilities.Add(new Ability("Rough Skin", "Inflicts damage to the attacker on contact.", (int)Enum.ability.Rough_Skin));
            abilities.Add(new Ability("Run Away", "Enables a sure getaway from wild Pokémon.", (int)Enum.ability.Run_Away));
            abilities.Add(new Ability("Sand Stream", "The Pokémon summons a sandstorm in battle.", (int)Enum.ability.Sand_Stream));
            abilities.Add(new Ability("Sand Veil", "Boosts the Pokémon's evasion in a sandstorm.", (int)Enum.ability.Sand_Veil));
            abilities.Add(new Ability("Scrappy", "Enables moves to hit Ghost-type foes.", (int)Enum.ability.Scrappy));
            abilities.Add(new Ability("Serene Grace", "Boosts the likelihood of added effects appearing.", (int)Enum.ability.Serene_Grace));
            abilities.Add(new Ability("Shadow Tag", "Prevents the foe from escaping.", (int)Enum.ability.Shadow_Tag));
            abilities.Add(new Ability("Shed Skin", "The Pokémon may heal its own status problems.", (int)Enum.ability.Shed_Skin));
            abilities.Add(new Ability("Sheer Force", "Increases the power of moves that have beneficial secondary effects by 30%, but removes those additional effects.", (int)Enum.ability.Sheer_Force));
            abilities.Add(new Ability("Shell Armor", "The Pokémon is protected against critical hits.", (int)Enum.ability.Shell_Armor));
            abilities.Add(new Ability("Shield Dust", "Blocks the added effects of attacks taken.", (int)Enum.ability.Shield_Dust));
            abilities.Add(new Ability("Soundproof", "Gives immunity to 'sound - based' moves.", (int)Enum.ability.Soundproof));
            abilities.Add(new Ability("Speed Boost", "Its Speed stat is gradually boosted.", (int)Enum.ability.Speed_Boost));
            abilities.Add(new Ability("Static", "Contact with the Pokémon may cause paralysis.", (int)Enum.ability.Static));
            abilities.Add(new Ability("Stench", "The stench may cause the target to flinch.", (int)Enum.ability.Stench));
            abilities.Add(new Ability("Sticky Hold", "Protects the Pokémon from item theft.", (int)Enum.ability.Sticky_Hold));
            abilities.Add(new Ability("Storm Drain", "Absorbs all Water-type moves to boost its Sp. Atk stat.", (int)Enum.ability.Sticky_Hold));
            abilities.Add(new Ability("Sturdy", "It cannot be knocked out with one hit.", (int)Enum.ability.Sturdy));
            abilities.Add(new Ability("Suction Cups", "Negates all moves that force switching out.", (int)Enum.ability.Suction_Cups));
            abilities.Add(new Ability("Swarm", "Powers up Bug-type moves when health is below 1/3.", (int)Enum.ability.Swarm));
            abilities.Add(new Ability("Swift Swim", "Boosts the Pokémon's Speed in rain.", (int)Enum.ability.Swift_Swim));
            abilities.Add(new Ability("Synchronize", "Passes a burn, poison, or paralysis to the foe.", (int)Enum.ability.Synchronize));
            abilities.Add(new Ability("Thick Fat", "Ups resistance to Fire- and Ice-type moves.", (int)Enum.ability.Thick_Fat));
            abilities.Add(new Ability("Torrent", "Powers up Water-type moves in a pinch.", (int)Enum.ability.Torrent));
            abilities.Add(new Ability("Trace", "The Pokémon copies a foe's Ability.", (int)Enum.ability.Trace));
            abilities.Add(new Ability("Truant", "Pokémon can't attack on consecutive turns.", (int)Enum.ability.Truant));
            abilities.Add(new Ability("Unaware", "When attacking, the Pokémon ignores the target Pokémon’s stat changes.", (int)Enum.ability.Unaware));
            abilities.Add(new Ability("Vital Spirit", "Prevents the Pokémon from falling asleep.", (int)Enum.ability.Vital_Spirit));
            abilities.Add(new Ability("Volt Absorb", "Restores HP if hit by an Electric-type move.", (int)Enum.ability.Volt_Absorb));
            abilities.Add(new Ability("Water Absorb", "Restores HP if hit by a Water-type move.", (int)Enum.ability.Water_Absorb));
            abilities.Add(new Ability("Water Veil", "Prevents the Pokémon from getting a burn.", (int)Enum.ability.Water_Veil));
            abilities.Add(new Ability("White Smoke", "Prevents other Pokémon from lowering its stats.", (int)Enum.ability.White_Smoke));
            abilities.Add(new Ability("Wonder Guard", "Only supereffective moves will hit.", (int)Enum.ability.Wonder_Guard));

            return abilities;
        }
    }
}

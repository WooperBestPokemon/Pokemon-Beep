using Pokemon_Beep.Battle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class AbilityFactory
    {
        private enum ability
        {
            Arena_Trap,
            Battle_Armor,
            Blaze,
            Chlorophyll,
            Clear_Body,
            Cloud_Nine,
            Compound_Eyes,
            Cute_Charm,
            Damp,
            Drizzle,
            Drought,
            Early_Bird,
            Effect_Spore,
            Flame_Body,
            Flash_Fire,
            Guts,
            Huge_Power,
            Hustle,
            Hyper_Cutter,
            Immunity,
            Inner_Focus,
            Insomnia,
            Intimidate,
            Keen_Eye,
            Levitate,
            Lightning_Rod,
            Limber,
            Liquid_Ooze,
            Magma_Armor,
            Magnet_Pull,
            Marvel_Scale,
            Minus,
            Natural_Cure,
            Oblivious,
            Overgrow,
            Own_Tempo,
            Pickup,
            Plus,
            Poison_Point,
            Pressure,
            PurevPower,
            Rain_Dish,
            Rock_Head,
            Rough_Skin,
            Run_Away,
            Sand_Stream,
            Sand_Veil,
            Serene_Grace,
            Shadow_Tag,
            Shed_Skin,
            Shell_Armor,
            Shield_Dust,
            Soundproof,
            Speed_Boost,
            Static,
            Stench,
            Sticky_Hold,
            Sturdy,
            Suction_Cups,
            Swarm,
            Swift_Swim,
            Synchronize,
            Thick_Fat,
            Torrent,
            Trace,
            Truant,
            Vital_Spirit,
            Volt_Absorb,
            Water_Absorb,
            Water_Veil,
            White_Smoke,
            Wonder_Guard
        }
        public List<Ability> GetAbilities()
        {
            List<Ability> abilities = new List<Ability>();

            abilities.Add(new Ability("Arena Trap", "Prevents the foe from fleeing.", (int)ability.Arena_Trap));
            abilities.Add(new Ability("Battle Armor", "The Pokémon is protected against critical hits.", (int)ability.Battle_Armor));
            abilities.Add(new Ability("Blaze", "Powers up Fire-type moves when health is below 1/3.", (int)ability.Blaze));
            abilities.Add(new Ability("Chlorophyll", "Boosts the Pokémon's Speed in sunshine.", (int)ability.Chlorophyll));
            abilities.Add(new Ability("Clear Body", "Prevents other Pokémon from lowering its stats.", (int)ability.Clear_Body));
            abilities.Add(new Ability("Cloud Nine", "Eliminates the effects of weather.", (int)ability.Cloud_Nine));
            abilities.Add(new Ability("Compound Eyes", "The Pokémon's accuracy is boosted.", (int)ability.Compound_Eyes));
            abilities.Add(new Ability("Cute Charm", "Contact with the Pokémon may cause infatuation.", (int)ability.Cute_Charm));
            abilities.Add(new Ability("Damp", "Prevents the use of self-destructing moves.", (int)ability.Damp));
            abilities.Add(new Ability("Drizzle", "The Pokémon makes it rain when it enters a battle.", (int)ability.Drizzle));
            abilities.Add(new Ability("Drought", "The Pokémon makes it sunny when it enters a battle.", (int)ability.Drought));
            abilities.Add(new Ability("Early Bird", "The Pokémon awakens quickly from sleep.", (int)ability.Early_Bird));
            abilities.Add(new Ability("Effect Spore", "Contact may poison or cause paralysis or sleep.", (int)ability.Effect_Spore));
            abilities.Add(new Ability("Flame Body", "Contact with the Pokémon may burn the attacker.", (int)ability.Flame_Body));
            abilities.Add(new Ability("Flash Fire", "It powers up Fire-type moves if it's hit by one.", (int)ability.Flash_Fire));
            abilities.Add(new Ability("Guts", "Boosts Attack if there is a status problem.", (int)ability.Guts));
            abilities.Add(new Ability("Huge Power", "Raises the Pokémon's Attack stat.", (int)ability.Huge_Power));
            abilities.Add(new Ability("Hustle", "Boosts the Attack stat, but lowers accuracy.", (int)ability.Hustle));
            abilities.Add(new Ability("Hyper Cutter", "Prevents other Pokémon from lowering Attack stat.", (int)ability.Hyper_Cutter));
            abilities.Add(new Ability("Immunity", "Prevents the Pokémon from getting poisoned.", (int)ability.Immunity));
            abilities.Add(new Ability("Inner Focus", "The Pokémon is protected from flinching.", (int)ability.Inner_Focus));
            abilities.Add(new Ability("Insomnia", "Prevents the Pokémon from falling asleep.", (int)ability.Insomnia));
            abilities.Add(new Ability("Intimidate", "Lowers the foe's Attack stat.", (int)ability.Intimidate));
            abilities.Add(new Ability("Keen_Eye", "Prevents other Pokémon from lowering accuracy.", (int)ability.Keen_Eye));
            abilities.Add(new Ability("Levitate", "Gives immunity to Ground type moves.", (int)ability.Levitate));
            abilities.Add(new Ability("Lightning Rod", "Draws in all Electric-type moves to up Sp. Attack.", (int)ability.Lightning_Rod));
            abilities.Add(new Ability("Limber", "The Pokémon is protected from paralysis.", (int)ability.Limber));
            abilities.Add(new Ability("Liquid Ooze", "Damages attackers using any draining move.", (int)ability.Liquid_Ooze));
            abilities.Add(new Ability("Magma Armor", "Prevents the Pokémon from becoming frozen.", (int)ability.Magma_Armor));
            abilities.Add(new Ability("Magnet Pull", "Prevents Steel-type Pokémon from escaping.", (int)ability.Magnet_Pull));
            abilities.Add(new Ability("Marvel Scale", "Ups Defense if there is a status problem.", (int)ability.Marvel_Scale));
            abilities.Add(new Ability("Minus", "Ups Sp. Atk if another Pokémon has Plus or Minus.", (int)ability.Minus));
            abilities.Add(new Ability("Natural Cure", "All status problems heal when it switches out.", (int)ability.Natural_Cure));
            abilities.Add(new Ability("Oblivious", "Prevents it from becoming infatuated.", (int)ability.Oblivious));
            abilities.Add(new Ability("Overgrow", "Powers up Grass-type moves in a pinch.", (int)ability.Overgrow));
            abilities.Add(new Ability("Own Tempo", "Prevents the Pokémon from becoming confused.", (int)ability.Own_Tempo));
            abilities.Add(new Ability("Pickup", "The Pokémon may pick up items.", (int)ability.Pickup));
            abilities.Add(new Ability("Plus", "Ups Sp. Atk if another Pokémon has Plus or Minus.", (int)ability.Plus));
            abilities.Add(new Ability("Poison Point", "Contact with the Pokémon may poison the attacker.", (int)ability.Poison_Point));
            abilities.Add(new Ability("Pressure", "The Pokémon raises the foe's PP usage.", (int)ability.Pressure));
            abilities.Add(new Ability("Rain Dish", "Raises the Pokémon's Attack stat.", (int)ability.Rain_Dish));
            abilities.Add(new Ability("Rock_Head", "Protects the Pokémon from recoil damage.", (int)ability.Rock_Head));
            abilities.Add(new Ability("Rough Skin", "Inflicts damage to the attacker on contact.", (int)ability.Rough_Skin));
            abilities.Add(new Ability("Run Away", "Enables a sure getaway from wild Pokémon.", (int)ability.Run_Away));
            abilities.Add(new Ability("Sand Stream", "The Pokémon summons a sandstorm in battle.", (int)ability.Sand_Stream));
            abilities.Add(new Ability("Sand Veil", "Boosts the Pokémon's evasion in a sandstorm.", (int)ability.Sand_Veil));
            abilities.Add(new Ability("Serene Grace", "Boosts the likelihood of added effects appearing.", (int)ability.Serene_Grace));
            abilities.Add(new Ability("Shadow Tag", "Prevents the foe from escaping.", (int)ability.Shadow_Tag));
            abilities.Add(new Ability("Shed Skin", "The Pokémon may heal its own status problems.", (int)ability.Shed_Skin));
            abilities.Add(new Ability("Shell Armor", "The Pokémon is protected against critical hits.", (int)ability.Shell_Armor));
            abilities.Add(new Ability("Shield Dust", "Blocks the added effects of attacks taken.", (int)ability.Shield_Dust));
            abilities.Add(new Ability("Soundproof", "Gives immunity to 'sound - based' moves.", (int)ability.Soundproof));
            abilities.Add(new Ability("Speed Boost", "Its Speed stat is gradually boosted.", (int)ability.Speed_Boost));
            abilities.Add(new Ability("Static", "Contact with the Pokémon may cause paralysis.", (int)ability.Static));
            abilities.Add(new Ability("Stench", "The stench may cause the target to flinch.", (int)ability.Stench));
            abilities.Add(new Ability("Sticky Hold", "Protects the Pokémon from item theft.", (int)ability.Sticky_Hold));
            abilities.Add(new Ability("Sturdy", "It cannot be knocked out with one hit.", (int)ability.Sturdy));
            abilities.Add(new Ability("Suction Cups", "Negates all moves that force switching out.", (int)ability.Suction_Cups));
            abilities.Add(new Ability("Swarm", "Powers up Bug-type moves when health is below 1/3.", (int)ability.Swarm));
            abilities.Add(new Ability("Swift Swim", "Boosts the Pokémon's Speed in rain.", (int)ability.Swift_Swim));
            abilities.Add(new Ability("Synchronize", "Passes a burn, poison, or paralysis to the foe.", (int)ability.Synchronize));
            abilities.Add(new Ability("Thick Fat", "Ups resistance to Fire- and Ice-type moves.", (int)ability.Thick_Fat));
            abilities.Add(new Ability("Torrent", "Powers up Water-type moves in a pinch.", (int)ability.Torrent));
            abilities.Add(new Ability("Trace", "The Pokémon copies a foe's Ability.", (int)ability.Trace));
            abilities.Add(new Ability("Truant", "Pokémon can't attack on consecutive turns.", (int)ability.Truant));
            abilities.Add(new Ability("Vital Spirit", "Prevents the Pokémon from falling asleep.", (int)ability.Vital_Spirit));
            abilities.Add(new Ability("Volt Absorb", "Restores HP if hit by an Electric-type move.", (int)ability.Volt_Absorb));
            abilities.Add(new Ability("Water Absorb", "Restores HP if hit by a Water-type move.", (int)ability.Water_Absorb));
            abilities.Add(new Ability("Water Veil", "Prevents the Pokémon from getting a burn.", (int)ability.Water_Veil));
            abilities.Add(new Ability("White Smoke", "Prevents other Pokémon from lowering its stats.", (int)ability.White_Smoke));
            abilities.Add(new Ability("Wonder Guard", "Only supereffective moves will hit.", (int)ability.Wonder_Guard));

            return abilities;
        }
    }
}

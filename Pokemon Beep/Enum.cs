﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    public static class Enum
    {
        public enum ability
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
            Leaf_Guard,
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
            Pure_Power,
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
            Unaware,
            Vital_Spirit,
            Volt_Absorb,
            Water_Absorb,
            Water_Veil,
            White_Smoke,
            Wonder_Guard
        }
        public enum type
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
        public enum experience
        {
            Erratic = 600000,
            Fast = 800000,
            Medium_Fast = 1000000,
            Medium_Slow = 1059860,
            Slow = 1250000,
            Fluctuating = 1640000
        }
        public enum shape
        {
            Flower,
            Bird,
            Snake,
            Bull,
            Seal,
            Dragon,
            Bug
        }
        public enum nature
        {
            Adamant,
            Bashful,
            Bold,
            Brave,
            Calm,
            Careful,
            Docile,
            Gentle,
            Hardy,
            Hasty,
            Impish,
            Jolly,
            Lax,
            Lonely,
            Mild,
            Modest,
            Naive,
            Naughty,
            Quiet,
            Quirky,
            Rash,
            Relaxed,
            Sassy,
            Serious,
            Timid
        }
        public enum gender
        {
            Both,
            Female_Only,
            Male_Only,
            No_Gender
        }
        public enum colour
        {
            Green,
            Blue,
            White,
        }
        public enum effect
        {
            noEffect,
            //StatChange
            lowerAttack,
            lowerDefense,
            lowerSpecialAttack,
            lowerSpecialDefense,
            lowerSpeed,
            lowerAccuracy,
            lowerEvasion,
            increaseAttack,
            increaseDefence,
            increaseSpecialAttack,
            increaseSpecialDefence,
            increaseSpeed,
            increaseEvasion,
            increaseCritical,
            //Status condition
            poison,
            burn,
            paralysis,
            sleep,
            frozen,
            bound,
            healStatus,
            //HP base
            heal,
            drain,
            knockback,
            //counter
            counter,
            mirror,
            //protection
            protect,
            protectStatus,
            lightScreen,
            reflect,
            //Meteo
            fog,
            rain,
            sandstorm,
            snow,
            sunny,
        }
        public enum move
        {
            Acid,
            Acid_Spray,
            Aqua_Tail,
            Aurora_Beam,
            Bug_Buzz,
            Charm,
            Confide,
            Cotton_Spore,
            Crunch,
            Crush_Claw,
            Cut,
            Dragon_Claw,
            Dragon_Pulse,
            Drill_Peck,
            Earth_Power,
            Eerie_Impulse,
            Egg_Bomb,
            Energy_Ball,
            Fairy_Wind,
            Fake_Tears,
            Feather_Dance,
            Flash_Cannon,
            Focus_Blast,
            Growl,
            Horn_Attack,
            Hydro_Pump,
            Hyper_Voice,
            Icy_Wind,
            Iron_Tail,
            Leer,
            Liquidation,
            Meditate,
            Mega_Kick,
            Mega_Punch,
            Megahorn,
            Metal_Sound,
            Moonblast,
            Mud_Shot,
            Mystical_Fire,
            Peck,
            Play_Rough,
            Pound,
            Power_Gem,
            Power_Whip,
            Psychic,
            Rain_Dance,
            Razor_Shell,
            Rock_Throw,
            Rock_Tomb,
            Scary_Face,
            Scratch,
            Screech,
            Seed_Bomb,
            Shadow_Ball,
            Sharpen,
            Slam,
            Snarl,
            Strength,
            String_Shot,
            Struggle_Bug,
            Tackle,
            Tail_Whip,
            Vine_Whip,
            Water_Gun,
            Wing_Attack
        }
    }
}

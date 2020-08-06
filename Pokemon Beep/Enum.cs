﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    public static class Enum
    {
        //Pokemon
        public enum pokemon
        {
            Chikorita,
            Bayleef,
            Meganium,
            Cyndaquil,
            Quilava,
            Typhlosion,
            Totodile,
            Croconaw,
            Feraligatr,
            Rattata,
            Raticate,
            Sentret,
            Furret,
            Zigzagoon,
            Linoone,
            Bidoof,
            Bibarel,
            Pidgey,
            Pidgeotto,
            Pidgeot,
            Hoothoot,
            Noctowl,
            Taillow,
            Swellow,
            Starly,
            Staravia,
            Staraptor,
            Caterpie,
            Metapod,
            Butterfree,
            Wurmple,
            Silcoon,
            Beautifly,
            Oddish,
            Gloom,
            Vileplume,
            Bellossom,
            Paras,
            Parasect,
            Spinarak,
            Ariados,
        }
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
            Frisk,
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
            Scrappy,
            Serene_Grace,
            Shadow_Tag,
            Shed_Skin,
            Sheer_Force,
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
        public enum side
        {
            Left,
            Right,
        }
        //Battle
        public enum move
        {
            Acid,
            Acid_Armor,
            Acid_Spray,
            Aerial_Ace,
            Agility,
            Air_Slash,
            Amnesia,
            Aqua_Tail,
            Astonish,
            Aura_Sphere,
            Aurora_Beam,
            Barrier,
            Bite,
            Blizzard,
            Body_Slam,
            Bounce,
            Brave_Bird,
            Bug_Buzz,
            Bullet_Seed,
            Charge_Beam,
            Charm,
            Coil,
            Comet_Punch,
            Confide,
            Cotton_Guard,
            Cotton_Spore,
            Crunch,
            Crush_Claw,
            Cut,
            Dark_Pulse,
            Defense_Curl,
            Detect,
            Disarming_Voice,
            Discharge,
            Double_Edge,
            Dragon_Breath,
            Dragon_Claw,
            Dragon_Pulse,
            Dragon_Rush,
            Drill_Peck,
            Earth_Power,
            Eerie_Impulse,
            Egg_Bomb,
            Electro_Ball,
            Ember,
            Endure,
            Energy_Ball,
            Extrasensory,
            Fairy_Wind,
            Fake_Tears,
            Feather_Dance,
            Feint_Attack,
            Fire_Blast,
            Fire_Fang,
            Fire_Punch,
            Flame_Charge,
            Flame_Wheel,
            Flamethrower,
            Flare_Blitz,
            Flash_Cannon,
            Focus_Blast,
            Force_Palm,
            Fury_Swipes,
            Giga_Impact,
            Glare,
            Grass_Whistle,
            Growl,
            Hail,
            Harden,
            Haze,
            Head_Charge,
            Headbutt,
            Heat_Wave,
            Horn_Attack,
            Hydro_Pump,
            Hyper_Beam,
            Hyper_Fang,
            Hyper_Voice,
            Hypnosis,
            Ice_Beam,
            Ice_Punch,
            Icicle_Spear,
            Icy_Wind,
            Inferno,
            Iron_Defense,
            Iron_Head,
            Iron_Tail,
            Lava_Plume,
            Leer,
            Lick,
            Liquidation,
            Lovely_Kiss,
            Magical_Leaf,
            Magnet_Bomb,
            Meditate,
            Mega_Kick,
            Mega_Punch,
            Megahorn,
            Metal_Sound,
            Moonblast,
            Mud_Shot,
            Mystical_Fire,
            Nasty_Plot,
            Nuzzle,
            Peck,
            Pin_Missile,
            Play_Rough,
            Poison_Powder,
            Pound,
            Powder_Snow,
            Power_Gem,
            Power_Whip,
            Protect,
            Psychic,
            Quick_Attack,
            Rain_Dance,
            Razor_Shell,
            Rest,
            Rock_Blast,
            Rock_Polish,
            Rock_Slide,
            Rock_Throw,
            Rock_Tomb,
            Sacred_Fire,
            Sandstorm,
            Scald,
            Scale_Shot,
            Scary_Face,
            Scratch,
            Screech,
            Seed_Bomb,
            Shadow_Ball,
            Shadow_Punch,
            Sharpen,
            Shock_Wave,
            Sing,
            Slam,
            Sleep_Powder,
            Sludge_Bomb,
            Sludge_Wave,
            Smart_Strike,
            Snarl,
            Spark,
            Spike_Cannon,
            Stomp,
            Strength,
            String_Shot,
            Struggle_Bug,
            Stun_Spore,
            Submission,
            Sucker_Punch,
            Sunny_Day,
            Super_Fang,
            Sweet_Kiss,
            Swift,
            Swords_Dance,
            Tackle,
            Tail_Slap,
            Tail_Whip,
            Take_Down,
            Thunder,
            Thunder_Punch,
            Thunder_Shock,
            Thunder_Wave,
            Thunderbolt,
            Toxic,
            Vine_Whip,
            Vital_Throw,
            Water_Gun,
            Waterfall,
            Will_O_Wisp,
            Wing_Attack,
            Withdraw,
            Yawn,
            Zap_Cannon,
            Zen_Headbutt,
        }
        public enum effect
        {
            noEffect,
            //StatChange
            selfLowerAttack,
            selfLowerDefense,
            selfLowerSpecialAttack,
            selfLowerSpecialDefense,
            selfLowerSpeed,
            selfLowerAccuracy,
            selfLowerEvasion,
            selfIncreaseAttack,
            selfIncreaseDefense,
            selfIncreaseSpecialAttack,
            selfIncreaseSpecialDefense,
            selfIncreaseSpeed,
            selfIncreaseAccuracy,
            selfIncreaseEvasion,
            selfIncreaseCritical,
            foeLowerAttack,
            foeLowerDefense,
            foeLowerSpecialAttack,
            foeLowerSpecialDefense,
            foeLowerSpeed,
            foeLowerAccuracy,
            foeLowerEvasion,
            foeIncreaseAttack,
            foeIncreaseDefense,
            foeIncreaseSpecialAttack,
            foeIncreaseSpecialDefense,
            foeIncreaseSpeed,
            foeIncreaseAccuracy,
            foeIncreaseEvasion,
            foeIncreaseCritical,
            //Status condition
            poison,
            burn,
            paralysis,
            sleep,
            selfSleep,
            yawn,
            freeze,
            bound,
            healStatus,
            confusion,
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
            endure,
            //Meteo
            fog,
            rain,
            sandstorm,
            snow,
            sunny,
            //Other
            resetStat,
            halvesHP,
            flinch,
            recoil,
            mustRecharge,
            multiHit,
            restoreFullHp,
            //unique
            electroBall,
            suckerPunch,
        }
        public enum weather
        {
            Clear,
            Rain,
            Sunny,
            Sandstorm,
            Hail,
        }
        public enum status
        {
            None,
            Poisoned,
            Badly_Poisoned,
            Paralyzed,
            Sleep,
            Frozen,
            Burned,
        }
        public enum stat
        {
            Attack,
            Defense,
            SpecialAttack,
            SpecialDefense,
            Speed,
            Critical,
        }
    }
}

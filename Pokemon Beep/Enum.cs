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
            MissingNo,
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
            Scyther,
            Scizor,
            Pinsir,
            Surskit,
            Masquerain,
            Horsea,
            Seadra,
            Kingdra,
            Finneon,
            Lumineon,
            Magikarp,
            Gyarados,
            NidoranF,
            Nidorina,
            Nidoqueen,
            NidoranM,
            Nidorino,
            Nidoking,
            Diglett,
            Dugtrio,
            Aron,
            Lairon,
            Aggron,
            Kabuto,
            Kabutops,
            Shieldon,
            Bastiodon,
            Dunsparce,
            Onix,
            Phanpy,
            Donphan,
            Sandshrew,
            Sandslash,
            Farfetchd,
            Sudowoodo,
            Swablu,
            Altaria,
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
            Dry_Skin,
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
            Storm_Drain,
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
            Normal,
            Fire,
            Water,
            Electric,
            Grass,
            Ice,
            Fighting,
            Poison,
            Ground,
            Fly,
            Psy,
            Bug,
            Rock,
            Ghost,
            Dragon,
            Dark,
            Steel,
            Fairy
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
        public enum item
        {
            Quick_Claw,
        }
        //Battle
        public enum move
        {
            Acid,
            Acid_Armor,
            Acid_Spray,
            Aerial_Ace,
            Agility,
            Air_Cutter,
            Air_Slash,
            Amnesia,
            Ancient_Power,
            Aqua_Jet,
            Aqua_Tail,
            Aromatherapy,
            Assurance,
            Astonish,
            Attract,
            Aura_Sphere,
            Aurora_Beam,
            Barrier,
            Bite,
            Blizzard,
            Block,
            Body_Slam,
            Bounce,
            Brave_Bird,
            Brick_Break,
            Brine,
            Bug_Buzz,
            Bulldoze,
            Bullet_Seed,
            Charge_Beam,
            Charm,
            Coil,
            Comet_Punch,
            Confide,
            Confuse_Ray,
            Confusion,
            Cotton_Guard,
            Cotton_Spore,
            Crabhammer,
            Cross_Chop,
            Cross_Poison,
            Crunch,
            Crush_Claw,
            Cut,
            Dark_Pulse,
            Defense_Curl,
            Defog,
            Disarming_Voice,
            Discharge,
            Dizzy_Punch,
            Double_Team,
            Double_Edge,
            Dragon_Breath,
            Dragon_Claw,
            Dragon_Dance,
            Dragon_Pulse,
            Dragon_Rage,
            Dragon_Rush,
            Drill_Peck,
            Drill_Run,
            Dynamic_Punch,
            Earth_Power,
            Eerie_Impulse,
            Egg_Bomb,
            Electro_Ball,
            Ember,
            Endeavor,
            Endure,
            Energy_Ball,
            Extrasensory,
            Facade,
            Fairy_Wind,
            Fake_Tears,
            Feather_Dance,
            Feint_Attack,
            Fire_Blast,
            Fire_Fang,
            Fire_Punch,
            Flail,
            Flame_Charge,
            Flame_Wheel,
            Flamethrower,
            Flare_Blitz,
            Flash,
            Flash_Cannon,
            Flatter,
            Focus_Blast,
            Focus_Energy,
            Force_Palm,
            Fury_Swipes,
            Giga_Impact,
            Glare,
            Grass_Knot,
            Grass_Whistle,
            Growl,
            Growth,
            Hail,
            Harden,
            Haze,
            Head_Charge,
            Headbutt,
            Heat_Wave,
            Hone_Claws,
            Horn_Attack,
            Howl,
            Hydro_Pump,
            Hyper_Beam,
            Hyper_Fang,
            Hyper_Voice,
            Hypnosis,
            Ice_Beam,
            Ice_Fang,
            Ice_Punch,
            Icicle_Spear,
            Icy_Wind,
            Inferno,
            Iron_Defense,
            Iron_Head,
            Iron_Tail,
            Karate_Chop,
            Lava_Plume,
            Leaf_Blade,
            Leech_Seed,
            Leer,
            Lick,
            Light_Screen,
            Liquidation,
            Lovely_Kiss,
            Magical_Leaf,
            Magnet_Bomb,
            Mean_Look,
            Meditate,
            Mega_Kick,
            Mega_Punch,
            Megahorn,
            Metal_Claw,
            Metal_Sound,
            Minimize,
            Mirror_Shot,
            Moonblast,
            Mud_Bomb,
            Mud_Shot,
            Muddy_Water,
            Mud_Slap,
            Mystical_Fire,
            Nasty_Plot,
            Night_Slash,
            Nuzzle,
            Octazooka,
            Outrage,
            Peck,
            Petal_Dance,
            Pin_Missile,
            Play_Rough,
            Poison_Powder,
            Pound,
            Powder_Snow,
            Power_Gem,
            Power_Whip,
            Protect,
            Psybeam,
            Psych_Up,
            Psychic,
            Psycho_Cut,
            Quick_Attack,
            Rain_Dance,
            Razor_Leaf,
            Razor_Shell,
            Reflect,
            Rest,
            Rock_Blast,
            Rock_Climb,
            Rock_Polish,
            Rock_Slide,
            Rock_Smash,
            Rock_Throw,
            Rock_Tomb,
            Roost,
            Sacred_Fire,
            Sand_Attack,
            Sandstorm,
            Scald,
            Scale_Shot,
            Scary_Face,
            Scratch,
            Screech,
            Seed_Bomb,
            Shadow_Ball,
            Shadow_Claw,
            Shadow_Punch,
            Sharpen,
            Shock_Wave,
            Signal_Beam,
            Silver_Wing,
            Sing,
            Slam,
            Slash,
            Sleep_Powder,
            Sludge_Bomb,
            Sludge_Wave,
            Smart_Strike,
            Smokescreen,
            Snarl,
            Spark,
            Spider_Web,
            Spike_Cannon,
            Splash,
            Spore,
            Stomp,
            Stone_Edge,
            Strength,
            String_Shot,
            Struggle_Bug,
            Stun_Spore,
            Submission,
            Sucker_Punch,
            Sunny_Day,
            Super_Fang,
            Superpower,
            Supersonic,
            Swagger,
            Sweet_Kiss,
            Sweet_Scent,
            Swift,
            Swords_Dance,
            Tackle,
            Tail_Slap,
            Tail_Whip,
            Take_Down,
            Taunt,
            Teeter_Dance,
            Thrash,
            Thunder,
            Thunder_Fang,
            Thunder_Punch,
            Thunder_Shock,
            Thunder_Wave,
            Thunderbolt,
            Tickle,
            Torment,
            Toxic,
            Twister,
            Vine_Whip,
            Vital_Throw,
            Water_Gun,
            Water_Pulse,
            Waterfall,
            Wild_Charge,
            Will_O_Wisp,
            Wing_Attack,
            Withdraw,
            Work_Up,
            X_Scissor,
            Yawn,
            Zap_Cannon,
            Zen_Headbutt,
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
            Accuracy,
            Evasion,
        }
        //Misc
        public enum location
        {
            //Plankalkül city
            Plankalkül,
            Plankalkül_Home,
            Plankalkül_House1,
            Plankalkül_House2,
            Plankalkül_House3,
            Plankalkül_House4,
        }
        public enum music
        {
            test,
        }
    }
}

﻿using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class PokemonFactory
    {
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
        public List<PocketMonster> GetPokemons()
        {
            List<PocketMonster> pokemons = new List<PocketMonster>();
            //Wooper
            List<int> typeWooper = new List<int>();
            typeWooper.Add((int)type.Water);
            typeWooper.Add((int)type.Ground);
            //pokemons.Add(new PocketMonster(001,"Wooper", "uwu", "uwu",))
            return pokemons;
        }
    }
}

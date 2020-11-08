using Pokemon_Beep.Combat;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pokemon_Beep.Pokemon
{
    class PokemonInfo
    {

        // Without Evolion

        //Pokemon with 2 types and 2 & more abilities
        public PokemonInfo(int pokedexID,string name,string description, int sexe, double height, double weight, List<int> types, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;
            Types = types;
            Abilities = abilities;
            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;
        }
        //Pokemon with 1 type and 2 & more abilities
        public PokemonInfo(int pokedexID, string name, string description, int sexe, double height, double weight, int type, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            Types = typePkm;

            Abilities = abilities;
            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;
        }
        //Pokemon with 2 types and 1 ability
        public PokemonInfo(int pokedexID, string name, string description, int sexe, double height, double weight, List<int> types, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;
            Types = types;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            Abilities = abilityPkm;

            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;
        }
        //Pokemon with 1 type and 1 ability
        public PokemonInfo(int pokedexID, string name, string description, int sexe, double height, double weight, int type, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            Types = typePkm;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            Abilities = abilityPkm;

            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;
        }

        // With Evolution
        //Pokemon with 2 types and 2 & more abilities With Evolution
        public PokemonInfo(int pokedexID, string name, string description, int sexe, double height, double weight, List<int> types, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset, PokemonInfo evolution, int levelEvolution)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;
            Types = types;
            Abilities = abilities;
            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;

            Evolution = evolution;
            LevelEvolution = levelEvolution;
            CanEvolve = true;
        }
        //Pokemon with 1 type and 2 & more abilities With Evolution
        public PokemonInfo(int pokedexID, string name, string description, int sexe, double height, double weight, int type, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset, PokemonInfo evolution, int levelEvolution)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            Types = typePkm;

            Abilities = abilities;
            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;

            Evolution = evolution;
            LevelEvolution = levelEvolution;
            CanEvolve = true;
        }
        //Pokemon with 2 types and 1 ability With Evolution
        public PokemonInfo(int pokedexID, string name, string description, int sexe, double height, double weight, List<int> types, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset, PokemonInfo evolution, int levelEvolution)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;
            Types = types;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            Abilities = abilityPkm;

            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;

            Evolution = evolution;
            LevelEvolution = levelEvolution;
            CanEvolve = true;
        }
        //Pokemon with 1 type and 1 ability With Evolution
        public PokemonInfo(int pokedexID, string name, string description, int sexe, double height, double weight, int type, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset, List<Move> tmset, PokemonInfo evolution, int levelEvolution)
        {
            PokedexID = pokedexID;
            Name = name;
            Description = description;
            Gender = sexe;
            Height = height;
            Weight = weight;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            Types = typePkm;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            Abilities = abilityPkm;

            CatchRate = catchRate;
            Experience = experience;
            BaseExperienceYield = baseExperienceYield;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpecialAttack = baseSpecialAttack;
            BaseSpecialDefense = baseSpecialDefense;
            BaseSpeed = baseSpeed;
            Learnset = learnset;

            Evolution = evolution;
            LevelEvolution = levelEvolution;
            CanEvolve = true;
        }

        //Get values
        public int PokedexID { get; }
        public string Name { get; }
        public int Gender { get; }
        public string Description { get; }
        public double Height { get; }
        public double Weight { get; }
        public List<int> Types { get; }
        public List<Move> Moves { get; }
        public List<Learnset> Learnset { get; }
        public List<Ability> Abilities { get; }
        //Base Stats
        public int BaseHP { get; }
        public int BaseAttack { get; }
        public int BaseDefense { get; }
        public int BaseSpecialAttack { get; }
        public int BaseSpecialDefense { get; }
        public int BaseSpeed { get; }
        //Stats
        public int HP { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int SpecialAttack { get; }
        public int SpecialDefense { get; }
        public int Speed { get; }
        //Evolution stuff
        public PokemonInfo Evolution { get; }
        public bool CanEvolve { get; }
        public int LevelEvolution { get; }
        //Other
        public int CatchRate { get; }
        public int BaseExperienceYield { get; }
        public int Experience { get; }
    }
}

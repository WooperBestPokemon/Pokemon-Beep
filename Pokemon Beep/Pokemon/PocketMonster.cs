using Pokemon_Beep.Combat;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pokemon_Beep.Pokemon
{
    class PocketMonster
    {
        //Generic Stats
        private int pokedexID;
        private string name, description;
        private int sexe;
        private double height, weight;
        private int colour, shape;
        private List<int> types;
        private List<Ability> abilities;
        private int catchRate, experience, baseExperienceYield;
        private int baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed;
        private List<Move> moves = new List<Move>();
        private List<Learnset> learnset;
        private bool canEvolve = false;
        private PocketMonster evolution;
        private int levelEvolution;
        //Pokemon Stat
        private List<Move> moveset = new List<Move>();
        private Ability ability;
        private char gender;
        private int ivHP = 0;
        private int ivAttack = 0;
        private int ivDefense = 0;
        private int ivSpecialAttack = 0;
        private int ivSpecialDefense = 0;
        private int ivSpeed = 0;
        private int hp, attack, defense, specialAttack, specialDefense, speed;
        private double natureAttack = 1;
        private double natureDefense = 1;
        private double natureSpecialAttack = 1;
        private double natureSpecialDefense = 1;
        private double natureSpeed = 1;
        private int nature = (int) Enum.nature.Docile;

        //Battle
        private int status = (int) Enum.status.None;
        public int[] stages = new int[6];
        public int currentHP;

        // Without Evolion

        //Pokemon with 2 types and 2 & more abilities
        public PocketMonster(int pokedexID,string name,string description, int sexe, double height, double weight, int colour, int shape, List<int> types, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;
            this.types = types;
            this.abilities = abilities;
            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }
        //Pokemon with 1 type and 2 & more abilities
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            types = typePkm;

            this.abilities = abilities;
            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }
        //Pokemon with 2 types and 1 ability
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, List<int> types, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;
            this.types = types;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            abilities = abilityPkm;

            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }
        //Pokemon with 1 type and 1 ability
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            types = typePkm;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            abilities = abilityPkm;

            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }

        // With Evolution
        //Pokemon with 2 types and 2 & more abilities With Evolution
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, List<int> types, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset, PocketMonster evolution, int levelEvolution)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;
            this.types = types;
            this.abilities = abilities;
            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;

            this.evolution = evolution;
            this.levelEvolution = levelEvolution;
            canEvolve = true;
        }
        //Pokemon with 1 type and 2 & more abilities With Evolution
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset, PocketMonster evolution, int levelEvolution)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            types = typePkm;

            this.abilities = abilities;
            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;

            this.evolution = evolution;
            this.levelEvolution = levelEvolution;
            canEvolve = true;
        }
        //Pokemon with 2 types and 1 ability With Evolution
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, List<int> types, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset, PocketMonster evolution, int levelEvolution)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;
            this.types = types;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            abilities = abilityPkm;

            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;

            this.evolution = evolution;
            this.levelEvolution = levelEvolution;
            canEvolve = true;
        }
        //Pokemon with 1 type and 1 ability With Evolution
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Move> moveset, List<Learnset> learnset, PocketMonster evolution, int levelEvolution)
        {
            this.pokedexID = pokedexID;
            this.name = name;
            this.description = description;
            this.sexe = sexe;
            this.height = height;
            this.weight = weight;
            this.colour = colour;
            this.shape = shape;

            List<int> typePkm = new List<int>();
            typePkm.Add(type);
            types = typePkm;

            List<Ability> abilityPkm = new List<Ability>();
            abilityPkm.Add(ability);
            abilities = abilityPkm;

            this.catchRate = catchRate;
            this.experience = experience;
            this.baseExperienceYield = baseExperienceYield;
            this.baseHP = baseHP;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefense = baseSpecialDefense;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;

            this.evolution = evolution;
            this.levelEvolution = levelEvolution;
            canEvolve = true;
        }
        public void generateWildPokemon(int level)
        {
            Level = level;
            generateIvs();
            generateNature();
            generateMoves();
            generateAbility();
            generateStats();
            generateGender();
        }
        public void levelUp()
        {
            //TODO generate move
            Level++;
            if(canEvolve)
                checkEvolution();
            generateStats();
        }
        private void generateIvs()
        {
            ivHP = Utilities.RandomNumber(0, 32);
            ivAttack = Utilities.RandomNumber(0, 32);
            ivDefense = Utilities.RandomNumber(0, 32);
            ivSpecialAttack = Utilities.RandomNumber(0, 32);
            ivSpecialDefense = Utilities.RandomNumber(0, 32);
            ivSpeed = Utilities.RandomNumber(0, 32);
        }
        private void generateNature()
        {
            nature = Utilities.RandomNumber(0, 25);
            switch (nature)
            {
                case (int)Enum.nature.Adamant:
                    natureAttack = 1.1;
                    natureSpecialAttack = 0.9;
                    break;
                case (int)Enum.nature.Bold:
                    natureDefense = 1.1;
                    natureAttack = 0.9;
                    break;
                case (int)Enum.nature.Brave:
                    natureAttack = 1.1;
                    natureSpeed = 0.9;
                    break;
                case (int)Enum.nature.Calm:
                    natureSpecialDefense = 1.1;
                    natureAttack = 0.9;
                    break;
                case (int)Enum.nature.Careful:
                    natureSpecialDefense = 1.1;
                    natureSpecialAttack = 0.9;
                    break;
                case (int)Enum.nature.Gentle:
                    natureSpecialDefense = 1.1;
                    natureDefense = 0.9;
                    break;
                case (int)Enum.nature.Hasty:
                    natureSpeed = 1.1;
                    natureDefense = 0.9;
                    break;
                case (int)Enum.nature.Impish:
                    natureDefense = 1.1;
                    natureSpecialAttack = 0.9;
                    break;
                case (int)Enum.nature.Jolly:
                    natureSpeed = 1.1;
                    natureSpecialAttack = 0.9;
                    break;
                case (int)Enum.nature.Lax:
                    natureDefense = 1.1;
                    natureSpecialDefense = 0.9;
                    break;
                case (int)Enum.nature.Lonely:
                    natureAttack = 1.1;
                    natureDefense = 0.9;
                    break;
                case (int)Enum.nature.Mild:
                    natureSpecialAttack = 1.1;
                    natureDefense = 0.9;
                    break;
                case (int)Enum.nature.Modest:
                    natureSpecialAttack = 1.1;
                    natureAttack = 0.9;
                    break;
                case (int)Enum.nature.Naive:
                    natureSpeed = 1.1;
                    natureSpecialDefense = 0.9;
                    break;
                case (int)Enum.nature.Naughty:
                    natureAttack = 1.1;
                    natureSpecialDefense = 0.9;
                    break;
                case (int)Enum.nature.Quiet:
                    natureSpecialAttack = 1.1;
                    natureSpeed = 0.9;
                    break;
                case (int)Enum.nature.Rash:
                    natureSpecialAttack = 1.1;
                    natureSpecialDefense = 0.9;
                    break;
                case (int)Enum.nature.Relaxed:
                    natureDefense = 1.1;
                    natureSpeed = 0.9;
                    break;
                case (int)Enum.nature.Sassy:
                    natureSpecialDefense = 1.1;
                    natureSpeed = 0.9;
                    break;
                case (int)Enum.nature.Timid:
                    natureSpeed = 1.1;
                    natureAttack = 0.9;
                    break;
            }
        }
        private void generateMoves()
        {
            //Get all the moves that the pokemon should already know by its level
            List<Move> pkmMoves = new List<Move>();
            for (int i = 0; i < learnset.Count; i++)
            {
                if (Level >= learnset[i].Level)
                    pkmMoves.Add(learnset[i].PkmMove);
            }
            //If there is 4 or less moves
            if(pkmMoves.Count <= 4)
            {
                for (int i = 0; i < pkmMoves.Count; i++)
                {
                    moveset.Add(pkmMoves[i]);
                }
            }
            //If there is more
            else
            {
                List<int> numbers = new List<int>();
                //Adding the last move the pokemon learned
                numbers.Add(pkmMoves.Count - 1);
                int number;
                //Randomize the rest of the moves
                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        number = Utilities.RandomNumber(0, pkmMoves.Count);
                    }
                    while (numbers.Contains(number));
                    numbers.Add(number);
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    moveset.Add(pkmMoves[numbers[i]]);
                }
            }
        }
        private void generateStats()
        {           
            //HP
            hp = Math.Abs((((2 * baseHP + ivHP + 31) * Level) / 100) + Level + 10);
            //Other Stat
            attack = (int) Math.Abs((Math.Abs(((2 * baseAttack + ivAttack + 31) * Level) / 100) + 5) * natureAttack);
            defense = (int)Math.Abs((Math.Abs(((2 * baseDefense + ivDefense + 31) * Level) / 100) + 5) * natureDefense);
            specialAttack = (int)Math.Abs((Math.Abs(((2 * baseSpecialAttack + ivSpecialAttack + 31) * Level) / 100) + 5) * natureSpecialAttack);
            specialDefense = (int)Math.Abs((Math.Abs(((2 * baseSpecialDefense + ivSpecialDefense + 31) * Level) / 100) + 5) * natureSpecialDefense);
            speed = (int)Math.Abs((Math.Abs(((2 * baseSpeed + ivSpeed + 31) * Level) / 100) + 5) * natureSpeed);
        }
        private void generateAbility()
        {
            ability = abilities[Utilities.RandomNumber(0, abilities.Count)];
        }
        private void generateGender()
        {
            if(sexe == (int) Enum.gender.Both)
            {
                int rand = Utilities.RandomNumber(1, 3);
                if(rand == 1)
                    gender = 'M';
                else
                    gender = 'F';
            }
            else if(sexe == (int) Enum.gender.Female_Only)
                gender = 'F';
            else if (sexe == (int)Enum.gender.Male_Only)
                gender = 'M';
            else
                gender = 'N';
        }
        private void checkEvolution()
        {
            //Now we check if the level is equal or superior to the evolution level
            if(Level >= levelEvolution)
            {
                //todo - When UI is done, ask here if you want to evolve your pokemon
                if(true)
                {
                    name = evolution.Name;
                    description = evolution.Description;
                    height = evolution.Height;
                    weight = evolution.Weight;
                    colour = evolution.Colour;
                    shape = evolution.Shape;
                    types = evolution.Types;
                    moves = evolution.Moves;
                    learnset = evolution.Learnset;
                    //todo something about abilities
                    //Stats
                    baseHP = evolution.BaseHP;
                    baseAttack = evolution.BaseAttack;
                    baseDefense = evolution.BaseDefense;
                    baseSpecialAttack = evolution.BaseSpecialAttack;
                    baseSpecialDefense = evolution.BaseSpecialDefense;
                    baseSpeed = evolution.BaseSpeed;
                    //If the evolution has an evolution
                    if (evolution.CanEvolve)
                    {
                        levelEvolution = evolution.LevelEvolution;
                        evolution = evolution.Evolution;
                    }
                    else
                    {
                        evolution = null;
                        //So It won't ask the next time it level up to evolve
                        levelEvolution = 255;
                    }
                }
            }
        }
        //battle
        public void resetStage()
        {
            for (int i = 0; i < stages.Length; i++)
            {
                stages[i] = 0;
            }
            stages[(int)Enum.stat.Attack] = 2;
        }
        public int getStage(int stat)
        {
            return stages[stat];
        }
        //Get values
        public int PokedexID
        {
            get { return pokedexID; }
        }
        public string Name
        {
            get { return name; }
        }
        public char Gender
        {
            get { return gender; }
        }
        public string Description
        {
            get { return description; }
        }
        public double Height
        {
            get { return height; }
        }
        public double Weight
        {
            get { return weight; }
        }
        public int Colour
        {
            get { return colour; }
        }
        public int Shape
        {
            get { return shape; }
        }
        public List<int> Types
        {
            get { return types; }
        }
        public int Level { get; set; }
        public List<Move> Moves
        {
            get { return moves; }
        }
        public List<Move> Moveset
        {
            get { return moveset; }
            set { moveset = value; }
        }
        public List<Learnset> Learnset
        {
            get { return learnset; }
        }
        public Ability Ability
        {
            get { return ability; }
        }
        //Base Stats
        public int BaseHP
        {
            get { return baseHP; }
        }
        public int BaseAttack
        {
            get { return baseAttack; }
        }
        public int BaseDefense
        {
            get { return baseDefense; }
        }
        public int BaseSpecialAttack
        {
            get { return baseSpecialAttack; }
        }
        public int BaseSpecialDefense
        {
            get { return baseSpecialDefense; }
        }
        public int BaseSpeed
        {
            get { return baseSpeed; }
        }
        //Stats
        public int HP
        {
            get { return hp; }
        }
        public int Attack
        {
            get { return attack; }
        }
        public int Defense
        {
            get { return defense; }
        }
        public int SpecialAttack
        {
            get { return specialAttack; }
        }
        public int SpecialDefense
        {
            get { return specialDefense; }
        }
        public int Speed
        {
            get { return speed; }
        }
        //Ivs
        public int IvHP
        {
            get { return ivHP; }
        }
        public int IvAttack
        {
            get { return ivAttack; }
        }
        public int IvDefense
        {
            get { return ivDefense; }
        }
        public int IvSpecialAttack
        {
            get { return ivSpecialAttack; }
        }
        public int IvSpecialDefense
        {
            get { return ivSpecialDefense; }
        }
        public int IvSpeed
        {
            get { return ivSpeed; }
        }
        //Battle
        public int Status
        {
            get { return status; }
        }

        //Evolution stuff
        public PocketMonster Evolution
        {
            get { return evolution; }
        }
        public bool CanEvolve
        {
            get { return canEvolve; }
        }
        public int LevelEvolution
        {
            get { return levelEvolution; }
        }
        //Int to String
        public string getNatureName()
        {
            string result = "Error";
            switch(nature)
            {
                case 0:
                    result = "Adamant";
                    break;
                case 1:
                    result = "Bashful";
                    break;
                case 2:
                    result = "Bold";
                    break;
                case 3:
                    result = "Brave";
                    break;
                case 4:
                    result = "Calm";
                    break;
                case 5:
                    result = "Careful";
                    break;
                case 6:
                    result = "Docile";
                    break;
                case 7:
                    result = "Gentle";
                    break;
                case 8:
                    result = "Hardy";
                    break;
                case 9:
                    result = "Hasty";
                    break;
                case 10:
                    result = "Impish";
                    break;
                case 11:
                    result = "Jolly";
                    break;
                case 12:
                    result = "Lax";
                    break;
                case 13:
                    result = "Lonely";
                    break;
                case 14:
                    result = "Mild";
                    break;
                case 15:
                    result = "Modest";
                    break;
                case 16:
                    result = "Naive";
                    break;
                case 17:
                    result = "Naughty";
                    break;
                case 18:
                    result = "Quiet";
                    break;
                case 19:
                    result = "Quirky";
                    break;
                case 20:
                    result = "Rash";
                    break;
                case 21:
                    result = "Relaxed";
                    break;
                case 22:
                    result = "Sassy";
                    break;
                case 23:
                    result = "Serious";
                    break;
                case 24:
                    result = "Timid";
                    break;
            }
            return result;
        }
        public string getStatusName()
        {
            string result = "Null";
            switch(status)
            {
                case 1:
                    result = "Poisoned";
                        break;
                case 2:
                    result = "Badly Poisoned";
                    break;
                case 3:
                    result = "Paralyzed";
                    break;
                case 4:
                    result = "Sleep";
                    break;
                case 5:
                    result = "Frozen";
                    break;
                case 6:
                    result = "Burned";
                    break;
            }
            return result;
        }
        public override string ToString()
        {
            String description =  "Name : " + name + "\n" +
                "Level : " + Level + "\n" +
                "Nature : " + getNatureName() + "\n" +
                "Sexe : " + gender + "\n" +
                "Ability : " + ability.Name + "\n" +
                "------------------" + "\n" +
                "Ivs" + "\n" +
                "------------------" + "\n" +
                "HP : " + ivHP + "\n" +
                "Attack : " + ivAttack + "\n" +
                "Defense : " + ivDefense + "\n" +
                "Special Attack : " + ivSpecialAttack + "\n" +
                "Special Defense : " + ivSpecialDefense + "\n" +
                "Speed : " + ivSpeed + "\n" +
                "------------------" + "\n" +
                "Stats" + "\n" +
                "------------------" + "\n" +
                "HP : " + hp + "\n" +
                "Attack : " + attack + "\n" +
                "Defense : " + defense + "\n" +
                "Special Attack : " + specialAttack + "\n" +
                "Special Defense : " + specialDefense + "\n" +
                "Speed : " + speed + "\n" +
                "------------------" + "\n" +
                "Moves" + "\n" +
                "------------------" + "\n";
            for (int i = 0; i < moveset.Count; i++)
            {
                description += i + 1 + ". " + moveset[i].Name + "\n";
            }
            return description;
        }
    }
}

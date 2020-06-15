using Pokemon_Beep.Battle;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pokemon_Beep.Pokemon
{
    class PocketMonster
    {
        //Generic
        private int pokedexID;
        private string name, description;
        private int sexe;
        private double height, weight;
        private int colour, shape;
        private List<int> types;
        private List<Ability> abilities;
        private int catchRate, experience, baseExperienceYield;
        private int baseHP, baseAttack, baseDefence, baseSpecialAttack, baseSpecialDefence, baseSpeed;
        private List<Learnset> learnset;
        //Pokemon Stat
        private List<Move> moves;
        private Ability ability;
        private int ivHP = 0;
        private int ivAttack = 0;
        private int ivDefence = 0;
        private int ivSpecialAttack = 0;
        private int ivSpecialDefence = 0;
        private int ivSpeed = 0;
        private int hp, attack, defence, specialAttack, specialDefence, speed;
        double natureAttack = 1;
        double natureDefence = 1;
        double natureSpecialAttack = 1;
        double natureSpecialDefence = 1;
        double natureSpeed = 1;
        private int nature = (int) Enum.nature.Docile;
        //Pokemon with 2 types and 2 & more abilities
        public PocketMonster(int pokedexID,string name,string description, int sexe, double height, double weight, int colour, int shape, List<int> types, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefence, int baseSpecialAttack, int baseSpecialDefence, int baseSpeed, List<Learnset> learnset)
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
            this.baseDefence = baseDefence;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefence = baseSpecialDefence;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }
        //Pokemon with 1 type and 2 & more abilities
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefence, int baseSpecialAttack, int baseSpecialDefence, int baseSpeed, List<Learnset> learnset)
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
            this.baseDefence = baseDefence;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefence = baseSpecialDefence;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }
        //Pokemon with 2 types and 1 ability
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, List<int> types, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefence, int baseSpecialAttack, int baseSpecialDefence, int baseSpeed, List<Learnset> learnset)
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
            this.baseDefence = baseDefence;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefence = baseSpecialDefence;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }
        //Pokemon with 1 type and 1 ability
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefence, int baseSpecialAttack, int baseSpecialDefence, int baseSpeed, List<Learnset> learnset)
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
            this.baseDefence = baseDefence;
            this.baseSpecialAttack = baseSpecialAttack;
            this.baseSpecialDefence = baseSpecialDefence;
            this.baseSpeed = baseSpeed;
            this.learnset = learnset;
        }
        public void generateWildPokemon(int level)
        {
            Level = level;
            generateIvs();
            generateNature();
            generateMoves();
            generateAbility();
            generateStats();
        }
        public void levelUp()
        {
            Level++;
            generateStats();
        }
        public List<int> Types
        {
            get { return types; }
        }
        public int Level { get; set; }
        private void generateIvs()
        {
            ivHP = Utilities.RandomNumber(0, 32);
            ivAttack = Utilities.RandomNumber(0, 32);
            ivDefence = Utilities.RandomNumber(0, 32);
            ivSpecialAttack = Utilities.RandomNumber(0, 32);
            ivSpecialDefence = Utilities.RandomNumber(0, 32);
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
                    natureDefence = 1.1;
                    natureAttack = 0.9;
                    break;
                case (int)Enum.nature.Brave:
                    natureAttack = 1.1;
                    natureSpeed = 0.9;
                    break;
                case (int)Enum.nature.Calm:
                    natureSpecialDefence = 1.1;
                    natureAttack = 0.9;
                    break;
                case (int)Enum.nature.Careful:
                    natureSpecialDefence = 1.1;
                    natureSpecialAttack = 0.9;
                    break;
                case (int)Enum.nature.Gentle:
                    natureSpecialDefence = 1.1;
                    natureDefence = 0.9;
                    break;
                case (int)Enum.nature.Hasty:
                    natureSpeed = 1.1;
                    natureDefence = 0.9;
                    break;
                case (int)Enum.nature.Impish:
                    natureDefence = 1.1;
                    natureSpecialAttack = 0.9;
                    break;
                case (int)Enum.nature.Jolly:
                    natureSpeed = 1.1;
                    natureSpecialAttack = 0.9;
                    break;
                case (int)Enum.nature.Lax:
                    natureDefence = 1.1;
                    natureSpecialDefence = 0.9;
                    break;
                case (int)Enum.nature.Lonely:
                    natureAttack = 1.1;
                    natureDefence = 0.9;
                    break;
                case (int)Enum.nature.Mild:
                    natureSpecialAttack = 1.1;
                    natureDefence = 0.9;
                    break;
                case (int)Enum.nature.Modest:
                    natureSpecialAttack = 1.1;
                    natureAttack = 0.9;
                    break;
                case (int)Enum.nature.Naive:
                    natureSpeed = 1.1;
                    natureSpecialDefence = 0.9;
                    break;
                case (int)Enum.nature.Naughty:
                    natureAttack = 1.1;
                    natureSpecialDefence = 0.9;
                    break;
                case (int)Enum.nature.Quiet:
                    natureSpecialAttack = 1.1;
                    natureSpeed = 0.9;
                    break;
                case (int)Enum.nature.Rash:
                    natureSpecialAttack = 1.1;
                    natureSpecialDefence = 0.9;
                    break;
                case (int)Enum.nature.Relaxed:
                    natureDefence = 1.1;
                    natureSpeed = 0.9;
                    break;
                case (int)Enum.nature.Sassy:
                    natureSpecialDefence = 1.1;
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
            for (int i = 0; i < Level; i++)
            {
                if (Level == learnset[i].Level)
                    pkmMoves.Add(learnset[i].PkmMove);
            }
            //If there is 4 or less moves
            if(pkmMoves.Count >= 4)
            {
                for (int i = 0; i < pkmMoves.Count; i++)
                {
                    moves[i] = pkmMoves[i];
                }
            }
            //If there is more
            else
            {
                List<int> numbers = new List<int>();
                int number;
                for (int i = 0; i < pkmMoves.Count; i++)
                {
                    do
                    {
                        number = Utilities.RandomNumber(0, pkmMoves.Count);
                    }
                    while (numbers.Contains(number));
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    moves[i] = pkmMoves[numbers[i]];
                }
            }
        }
        private void generateStats()
        {           
            //hp
            hp = Math.Abs((((2 * baseHP + ivHP + 31) * Level) / 100) + Level + 10);
            //other stat
            attack = (int) Math.Abs((Math.Abs(((2 * baseAttack + ivAttack + 31) * Level) / 100) + 5) * natureAttack);
            defence = (int)Math.Abs((Math.Abs(((2 * baseDefence + ivDefence + 31) * Level) / 100) + 5) * natureDefence);
            specialAttack = (int)Math.Abs((Math.Abs(((2 * baseSpecialAttack + ivSpecialAttack + 31) * Level) / 100) + 5) * natureSpecialAttack);
            specialDefence = (int)Math.Abs((Math.Abs(((2 * baseSpecialDefence + ivSpecialDefence + 31) * Level) / 100) + 5) * natureSpecialDefence);
            speed = (int)Math.Abs((Math.Abs(((2 * baseSpeed + ivSpeed + 31) * Level) / 100) + 5) * natureSpeed);
        }
        private void generateAbility()
        {
            ability = abilities[Utilities.RandomNumber(0, abilities.Count)];
        }
    }
}

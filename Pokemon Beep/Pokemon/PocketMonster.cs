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
        private List<Learnset> learnset;
        //Pokemon Stat
        private List<Move> moves = new List<Move>();
        private Ability ability;
        private char gender;
        private int ivHP = 0;
        private int ivAttack = 0;
        private int ivDefense = 0;
        private int ivSpecialAttack = 0;
        private int ivSpecialDefense = 0;
        private int ivSpeed = 0;
        private int hp, attack, defense, specialAttack, specialDefense, speed;
        double natureAttack = 1;
        double natureDefense = 1;
        double natureSpecialAttack = 1;
        double natureSpecialDefense = 1;
        double natureSpeed = 1;
        private int nature = (int) Enum.nature.Docile;

        //Pokemon with 2 types and 2 & more abilities
        public PocketMonster(int pokedexID,string name,string description, int sexe, double height, double weight, int colour, int shape, List<int> types, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset)
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
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, List<Ability> abilities, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset)
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
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, List<int> types, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset)
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
        public PocketMonster(int pokedexID, string name, string description, int sexe, double height, double weight, int colour, int shape, int type, Ability ability, int catchRate, int experience, int baseExperienceYield, int baseHP, int baseAttack, int baseDefense, int baseSpecialAttack, int baseSpecialDefense, int baseSpeed, List<Learnset> learnset)
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
                    moves.Add(pkmMoves[i]);
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
                    moves.Add(pkmMoves[numbers[i]]);
                }
            }
        }
        private void generateStats()
        {           
            //hp
            hp = Math.Abs((((2 * baseHP + ivHP + 31) * Level) / 100) + Level + 10);
            //other stat
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
        public string getNature()
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
        public override string ToString()
        {
            String description =  "Name : " + name + "\n" +
                "Level : " + Level + "\n" +
                "Nature : " + getNature() + "\n" +
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
            for (int i = 0; i < moves.Count; i++)
            {
                description += i + 1 + ". " + moves[i].Name + "\n";
            }
            return description;
        }
    }
}

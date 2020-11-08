using Pokemon_Beep.Combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Pokemon
{
    partial class PocketMonster
    {
        //Generation
        private void generateWildPokemon()
        {
            Nickname = Pokedex.getInfo(PokedexID).Name;
            Nature = Utilities.RandomNumber(0, 25);
            generateIvs();
            generateStats();
            generateAbility();
            generateMoves();
            generateGender();
            generateShiny();
            CurrentHP = HP;
        }
        private void generateGender()
        {
            int sexe = Pokedex.getInfo(PokedexID).Gender;
            if (sexe == (int)Enum.gender.Both)
            {
                int rand = Utilities.RandomNumber(1, 3);
                if (rand == 1)
                    Gender = 'M';
                else
                    Gender = 'F';
            }
            else if (sexe == (int)Enum.gender.Female_Only)
                Gender = 'F';
            else if (sexe == (int)Enum.gender.Male_Only)
                Gender = 'M';
            else
                Gender = 'N';
        }
        private void generateIvs()
        {
            IvHP = Utilities.RandomNumber(0, 32);
            IvAttack = Utilities.RandomNumber(0, 32);
            IvDefense = Utilities.RandomNumber(0, 32);
            IvSpAttack = Utilities.RandomNumber(0, 32);
            IvSpDefense = Utilities.RandomNumber(0, 32);
            IvSpeed = Utilities.RandomNumber(0, 32);
        }
        private void generateStats()
        {
            //Get the nature multiplicator
            double natureAttack = 1;
            double natureDefense = 1;
            double natureSpecialAttack = 1;
            double natureSpecialDefense = 1;
            double natureSpeed = 1;
            switch (Nature)
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
            //Get the infos
            int baseHP = Pokedex.getInfo(PokedexID).BaseHP;
            int baseAttack = Pokedex.getInfo(PokedexID).BaseAttack;
            int baseDefense = Pokedex.getInfo(PokedexID).BaseDefense;
            int baseSpAttack = Pokedex.getInfo(PokedexID).BaseSpecialAttack;
            int baseSpDefense = Pokedex.getInfo(PokedexID).BaseSpecialDefense;
            int baseSpeed = Pokedex.getInfo(PokedexID).BaseSpeed;

            //HP
            int newHP = Math.Abs((((2 * baseHP + IvHP + 31) * Level) / 100) + Level + 10);

            if (CurrentHP != HP)
                CurrentHP += newHP - HP;
            HP = newHP;

            //Other Stat
            Attack = (int)Math.Abs((Math.Abs(((2 * baseAttack + IvAttack + 31) * Level) / 100) + 5) * natureAttack);
            Defense = (int)Math.Abs((Math.Abs(((2 * baseDefense + IvDefense + 31) * Level) / 100) + 5) * natureDefense);
            SpAttack = (int)Math.Abs((Math.Abs(((2 * baseSpAttack + IvSpAttack + 31) * Level) / 100) + 5) * natureSpecialAttack);
            SpDefense = (int)Math.Abs((Math.Abs(((2 * baseSpDefense + IvSpDefense + 31) * Level) / 100) + 5) * natureSpecialDefense);
            Speed = (int)Math.Abs((Math.Abs(((2 * baseSpeed + IvSpeed + 31) * Level) / 100) + 5) * natureSpeed);
        }
        private void generateAbility()
        {
            List<Ability> abilities = Pokedex.getInfo(PokedexID).Abilities;
            PkmnAbility = abilities[Utilities.RandomNumber(0, abilities.Count)];
        }
        private void generateMoves()
        {
            //Get all the moves that the pokemon should already know by its level
            List<Move> pkmMoves = new List<Move>();
            List<Learnset> learnset = Pokedex.getInfo(PokedexID).Learnset;
            for (int i = 0; i < learnset.Count; i++)
            {
                if (Level >= learnset[i].Level)
                    pkmMoves.Add(learnset[i].PkmMove);
            }
            //If there is 4 or less moves
            if (pkmMoves.Count <= 4)
            {
                for (int i = 0; i < pkmMoves.Count; i++)
                    Moveset.Add(pkmMoves[i]);
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
                    Moveset.Add(pkmMoves[numbers[i]]);
            }
        }
        private void generateShiny()
        {
            if (Utilities.RandomNumber(1, 8193) == 1)
                Shiny = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_Beep.Combat;
using Pokemon_Beep.Other;

namespace Pokemon_Beep.Pokemon
{
    [Serializable]
    partial class PocketMonster
    {
        //Trainer Pokemon
        public PocketMonster(int pokedexID, string nickname, int level, int gender, bool shiny, Item item, Ability ability, List<Move> moves, int nature, int ivHP, int ivAttack, int ivDefense, int ivSpAttack, int ivSpDefense, int ivSpeed)
        {
            PokedexID = pokedexID;
            Nickname = nickname;
            Level = level;
            Gender = gender;
            Shiny = shiny;
            HeldItem = item;
            PkmnAbility = ability;
            Moveset = moves;
            Nature = nature;
            IvHP = ivHP;
            IvAttack = ivAttack;
            IvDefense = ivDefense;
            IvSpAttack = ivSpAttack;
            IvSpDefense = ivSpDefense;
            IvSpeed = ivSpeed;

            Types = Pokedex.getInfo(PokedexID).Types;

            generateStats();
        }
        //Wild Pokemon
        public PocketMonster(int pokedexID, int level)
        {
            PokedexID = pokedexID;
            Level = level;
            Types = Pokedex.getInfo(PokedexID).Types;
            generateWildPokemon();
        }
        //Basic Information
        public int PokedexID { get; set; }
        public string Nickname { get; set; }
        public List<int> Types { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int Gender { get; set; }
        public bool Shiny { get; set; }
        //Battle Information
        public Item HeldItem { get; set; }
        public Ability PkmnAbility { get; set; }
        public List<Move> Moveset { get; set; } = new List<Move>();
        public int Nature { get; set; }
        //Stats
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
        //Ivs
        public int IvHP { get; set; }
        public int IvAttack { get; set; }
        public int IvDefense { get; set; }
        public int IvSpAttack { get; set; }
        public int IvSpDefense { get; set; }
        public int IvSpeed { get; set; }
        //Battle information
        public int CurrentHP { get; set; }
        public int[] Stages { get; set; } = new int[8];
        public int Status { get; set; }

        //Level void
        public void receiveXP(int amountXP)
        {
            XP += amountXP;

         
        }
        public void levelUp()
        {
            //todo - create a leveling up system that will check if the pokemon can learn a move
        }
        public void resetStage()
        {
            for (int i = 0; i < Stages.Length; i++)
                Stages[i] = 0;
        }
    }
}

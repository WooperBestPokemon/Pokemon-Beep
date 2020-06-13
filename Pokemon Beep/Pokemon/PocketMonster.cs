using Pokemon_Beep.Battle;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Pokemon
{
    class PocketMonster
    {
        private int pokedexID, experience;
        private string name, height, weight;
        private List<Ability> abilities;
        private List<char> genders;
        public List<int> types;
        public PocketMonster(int pokedexID, string name, string height, string weight, List<Ability> abilities, List<char> genders, List<int> types, int experience)
        {
            this.types = types;
        }
        public PocketMonster(int pokedexID, string name, string height, string weight, List<Ability> abilities, List<char> genders, List<int> types, PocketMonster evolution, int evolitionLevel)
        {

        }
        public int getLevel()
        {
            return 0;
        }
        public int getSpecialAttack()
        {
            return 0;
        }
        public int getAttack()
        {
            return 0;
        }
        public int getDefence()
        {
            return 0;
        }
        public int getSpecialDefence()
        {
            return 0;
        }
    }
}

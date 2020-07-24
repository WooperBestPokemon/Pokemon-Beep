using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Player
{
    /// <summary>
    /// Class that store the information of the player, like the name, the gender, ect... 
    /// </summary>
    class Protagonist
    {
        //When you create a character
        public Protagonist(string name, int sexe)
        {
            Name = name;
            Sexe = sexe;
        }
        //When you load a character
        public Protagonist(string name, int sexe, int money, Inventory inventory, List<PocketMonster> pokemons, Story journal, PC computer)
        {
            Name = name;
            Sexe = sexe;
            Money = money;
            PlayerInventory = inventory;
            Pokemons = pokemons;
            Journal = journal;
            Computer = computer;
        }
        public string Name { get; }
        public int Sexe { get; set; }
        public int Money { get; set; }
        public Inventory PlayerInventory { get; }
        public List<PocketMonster> Pokemons { get; }
        public Story Journal { get; }
        public PC Computer { get; }
    }
}

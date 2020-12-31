using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pokemon_Beep.Combat;
using Pokemon_Beep.Other;
using Pokemon_Beep.Player;

namespace Pokemon_Beep.Factory
{
    class ItemFactory
    {
        delegate void effect(Protagonist player);
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            //Categorie : Berries

            //Oran Berry
            void OranBerry(Protagonist player)
            { heal(player, 10); }
            effect OranBerryEffect = new effect(OranBerry);
            items.Add(new Item("Oran Berry", "It can restores 10 HP.", (int)Enum.categorie.Berries, OranBerryEffect));

            return items;
        }
        //Function that most items will use
        private int selectPokemon(Protagonist player)
        {
            return 0;
        }
        private void writeMessage(string message, bool battle)
        {
            //Player is inside a battle
            if(battle == true)
            {

            }
            //Outside in the overworld
            else
            {

            }
        }
        //Healing Item
        private void heal(Protagonist player, int nbHP)
        {
            //Loop until it works or the player cancel
            bool operation = true;
            while (operation)
            {
                int choice = selectPokemon(player);

                if (player.Pokemons[choice].CurrentHP == player.Pokemons[choice].HP)
                    writeMessage("This action will have no effect.", true);
                //6 is the cancel number.
                else if (choice == 6)
                    operation = false;
                else
                {
                    int difference = nbHP;
                    player.Pokemons[choice].CurrentHP += nbHP;
                    //If the CurrentHP are over its maximum HP
                    if (player.Pokemons[choice].CurrentHP > player.Pokemons[choice].HP)
                    {
                        difference = player.Pokemons[choice].CurrentHP - player.Pokemons[choice].HP;
                        player.Pokemons[choice].CurrentHP -= difference;
                    }
                    writeMessage(player.Pokemons[choice].Nickname + " has restored " + (nbHP - difference) + " HP.", true);
                    operation = false;
                }

            }
        }
    }
}

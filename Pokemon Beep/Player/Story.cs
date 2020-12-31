using Pokemon_Beep.Factory;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Player
{
    /// <summary>
    /// This class will be used for the story/event. It will also track what the player did.
    /// </summary>
    [Serializable]
    class Story
    {
        /*
        public PocketMonster starter(int choice)
        {
            PocketMonster pkmnStarter;
            switch (choice)
            {
                //Chikorita
                case 1:
                    pkmnStarter = pokemonFactory.Chikorita();
                    break;
                //Cyndaquil
                case 2:
                    pkmnStarter = pokemonFactory.Cyndaquil();
                    break;
                //Totodile
                case 3:
                    pkmnStarter = pokemonFactory.Totodile();
                    break;
                //In case of an error or something
                default:
                    pkmnStarter = pokemonFactory.MissingNo();
                    break;
            }
            pkmnStarter.generateWildPokemon(5);
            //Ask here if you want to rename it
            return pkmnStarter;
        }
        */
    }
}

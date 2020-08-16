using Pokemon_Beep.Pokemon;
using Pokemon_Beep.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Combat
{
    partial class Battle
    {
        public void startWildBattle(Protagonist player, PocketMonster pocketMonster)
        {
            PkmnBattleInfo pokemonPlayer = new PkmnBattleInfo(getPlayerPokemon(player));
            PkmnBattleInfo pokemonFoe = new PkmnBattleInfo(pocketMonster);
            //Battle Music
            //Battle Animation
            while (true)
            {
                //LOOP until the wild pokemon is defeated or the player doesn't have any healty pokemon left
                //Make player choose his move
                //Make the AI choose his move
                /*
                if(playerAttackFirst)
                {

                }
                else
                {

                }
                */
            }


            //Check who attack first
            //Check and do first move
            //Check if Health > 0
            //
            //
        }       
    }
}

using Pokemon_Beep.Pokemon;
using Pokemon_Beep.Player;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Pokemon_Beep.AI;
using System.Security.Permissions;

namespace Pokemon_Beep.Combat
{
    partial class Battle
    {
        private Thread music = new Thread(() => Utilities.startMusic(0));
        public void startWildBattle(Protagonist player, PocketMonster pocketMonster, int background)
        {
            PkmnBattleInfo playerPokemon = new PkmnBattleInfo(getPlayerPokemon(player));
            PkmnBattleInfo wildPokemon = new PkmnBattleInfo(pocketMonster);
            DamageCalculator damageCalculator = new DamageCalculator();
            WildPokemonAI ai = new WildPokemonAI(wildPokemon.Pokemon);
            
            bool battleIsOver = false;
            //Battle Music
            music.Start();
            //TODO Battle Animation
            //LOOP until the wild pokemon is defeated or the player doesn't have any healty pokemon left
            while (!(battleIsOver))
            {
                //Make player choose his move
                //Make the AI choose his move
                int aiChoice = ai.getChoice();
                /*
                if(playerAttackFirst)
                {

                }
                else
                {

                }
                */
            }        
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void KillTheThread()
        {
            music.Abort();
        }
    }
}

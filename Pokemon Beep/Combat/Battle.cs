using Pokemon_Beep.Pokemon;
using Pokemon_Beep.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Combat
{
    class Battle
    {
        public void startWildBattle(Protagonist player, PocketMonster pocketMonster)
        {
            PkmnBattleInfo pokemonPlayer = new PkmnBattleInfo(getPlayerPokemon(player));
            PkmnBattleInfo pokemonFoe = new PkmnBattleInfo(pocketMonster);
            //Battle Music
            //Battle Animation
            //LOOP until the wild pokemon is defeated or the player doesn't have any healty pokemon left
            //Make player choose his move
            //Make the AI choose his move depending of the difficulty
            //Check who attack first
            //Check and do first move
            //Check if Health > 0
                //
            //
        }
        private PocketMonster getPlayerPokemon(Protagonist player)
        {
            if(player.Pokemons[0].currentHP == 0)
            {
                if (player.Pokemons[1].currentHP == 0)
                {
                    if (player.Pokemons[2].currentHP == 0)
                    {
                        if (player.Pokemons[3].currentHP == 0)
                        {
                            if (player.Pokemons[4].currentHP == 0)
                            {
                                return player.Pokemons[5];
                            }
                            else
                                return player.Pokemons[4];
                        }
                        else
                            return player.Pokemons[3];
                    }
                    else
                        return player.Pokemons[2];
                }
                else
                    return player.Pokemons[1];
            }
            else
                return player.Pokemons[0];
        }
        public bool playerAttackFirst(PkmnBattleInfo pokemonPlayer, PkmnBattleInfo pokemonFoe, Move movePlayer, Move moveFoe)
        {
            bool playerAttackFirst;

            //Check if both move has the same priority
            if (movePlayer.Priority == moveFoe.Priority)
            {
                BattleStatus battleStatus = new BattleStatus();
                double speedPlayer = pokemonPlayer.Pokemon.Speed * battleStatus.getStageMultiplicator(pokemonPlayer.Pokemon.stages[(int)Enum.stat.Speed]);
                double speedFoe = pokemonFoe.Pokemon.Speed * battleStatus.getStageMultiplicator(pokemonFoe.Pokemon.stages[(int)Enum.stat.Speed]);

                //Check the speed of the player
                if (speedPlayer > speedFoe)
                    playerAttackFirst = true;
                else if(speedPlayer < speedFoe)
                    playerAttackFirst = false;
                //if they have the same speed
                else
                {
                    if(Utilities.RandomNumber(1,2) == 1)
                        playerAttackFirst = true;
                    else
                        playerAttackFirst = false;
                }
                //TODO check if anyone is wearing a Quick Claw                 
            }
            else
            {
                if (movePlayer.Priority > moveFoe.Priority)
                    playerAttackFirst = true;
                else
                    playerAttackFirst = false;
            }
            return playerAttackFirst;
        }
    }
}

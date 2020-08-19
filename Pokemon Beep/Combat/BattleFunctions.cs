using Pokemon_Beep.Player;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Combat
{
    partial class Battle
    {
        private BattleStatus battleStatus = new BattleStatus();
        private PocketMonster getPlayerPokemon(Protagonist player)
        {
            return player.Pokemons.Find(x => x.currentHP != 0);
        }
        public bool playerAttackFirst(PkmnBattleInfo pokemonPlayer, PkmnBattleInfo pokemonFoe, Move movePlayer, Move moveFoe)
        {
            bool playerAttackFirst;
            //TODO check the action of the player, like switching / using an item
            //Check if both move has the same priority
            if (movePlayer.Priority == moveFoe.Priority)
            {
                BattleStatus battleStatus = new BattleStatus();
                double speedPlayer = pokemonPlayer.Pokemon.Speed * battleStatus.getStageMultiplicator(pokemonPlayer.Pokemon.stages[(int)Enum.stat.Speed]);
                double speedFoe = pokemonFoe.Pokemon.Speed * battleStatus.getStageMultiplicator(pokemonFoe.Pokemon.stages[(int)Enum.stat.Speed]);

                //Check the speed of the player
                if (speedPlayer > speedFoe)
                    playerAttackFirst = true;
                else if (speedPlayer < speedFoe)
                    playerAttackFirst = false;
                //if they have the same speed
                else
                {
                    if (Utilities.RandomNumber(1, 2) == 1)
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
        public bool attackHit(PkmnBattleInfo attacker, PkmnBattleInfo defender, Move move)
        {
            double otherMods = 1;

            //Check the abilities that modify the accuracy
            if (move.Category == "Physical" && attacker.Pokemon.Ability.Effect == (int)Enum.ability.Hustle)
                otherMods -= 0.2;
            else if(attacker.Pokemon.Ability.Effect == (int)Enum.ability.Compound_Eyes)
                otherMods += 0.3;

            double A = move.Accuracy * (battleStatus.getStageMultiplicator(defender.Pokemon.stages[(int)Enum.stat.Evasion]) / battleStatus.getStageMultiplicator(attacker.Pokemon.stages[(int)Enum.stat.Accuracy])) * otherMods;
            int random = Utilities.RandomNumber(1, 100);

            if (random <= A)
                return true;
            else
                return false;
        }
    }
}

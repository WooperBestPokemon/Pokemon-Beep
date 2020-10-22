﻿using Pokemon_Beep.Player;
using Pokemon_Beep.Pokemon;

namespace Pokemon_Beep.Combat
{
    partial class Battle
    {
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
                double speedPlayer = pokemonPlayer.Pokemon.Speed * getStageMultiplicator(pokemonPlayer.Pokemon.stages[(int)Enum.stat.Speed]);
                double speedFoe = pokemonFoe.Pokemon.Speed * getStageMultiplicator(pokemonFoe.Pokemon.stages[(int)Enum.stat.Speed]);

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
            else if (attacker.Pokemon.Ability.Effect == (int)Enum.ability.Compound_Eyes)
                otherMods += 0.3;

            double A = move.Accuracy * (getStageMultiplicator(defender.Pokemon.stages[(int)Enum.stat.Evasion]) / getStageMultiplicator(attacker.Pokemon.stages[(int)Enum.stat.Accuracy])) * otherMods;
            int random = Utilities.RandomNumber(1, 101);

            if (random <= A)
                return true;
            else
                return false;
        }
        private double getStageMultiplicator(int stage)
        {
            if (stage == 0)
                return 1;
            else if (stage == 1)
                return 1.5;
            else if (stage == 2)
                return 2;
            else if (stage == 3)
                return 2.5;
            else if (stage == 4)
                return 3;
            else if (stage == 5)
                return 3.5;
            else if (stage == 6)
                return 4;
            else if (stage == -1)
                return (double)2 / 3;
            else if (stage == -2)
                return (double)2 / 4;
            else if (stage == -3)
                return (double)2 / 5;
            else if (stage == -4)
                return (double)2 / 6;
            else if (stage == -5)
                return (double)2 / 7;
            else if (stage == -6)
                return (double)2 / 8;
            else
                return 1;
        }
    }
}
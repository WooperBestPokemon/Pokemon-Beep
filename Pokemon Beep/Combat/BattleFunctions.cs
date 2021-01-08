using Pokemon_Beep.Player;
using Pokemon_Beep.Pokemon;
using System;

namespace Pokemon_Beep.Combat
{
    partial class Battle
    {
        private PocketMonster getPlayerPokemon(Protagonist player)
        {
            return player.Pokemons.Find(x => x.CurrentHP != 0);
        }
        public bool playerAttackFirst(PkmnBattleInfo pokemonPlayer, PkmnBattleInfo pokemonFoe, Move movePlayer, Move moveFoe)
        {
            bool playerAttackFirst;
            //TODO check the action of the player, like switching / using an item
            //Check if both move has the same priority
            if (movePlayer.Priority == moveFoe.Priority)
            {
                double speedPlayer = pokemonPlayer.Pokemon.Speed * getStageMultiplicator(pokemonPlayer.Pokemon.Stages[(int)Enum.stat.Speed]);
                double speedFoe = pokemonFoe.Pokemon.Speed * getStageMultiplicator(pokemonFoe.Pokemon.Stages[(int)Enum.stat.Speed]);

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
            if (move.Category == "Physical" && attacker.Pokemon.PkmnAbility.Effect == (int)Enum.ability.Hustle)
                otherMods -= 0.2;
            else if (attacker.Pokemon.PkmnAbility.Effect == (int)Enum.ability.Compound_Eyes)
                otherMods += 0.3;

            double A = move.Accuracy * (getStageMultiplicator(defender.Pokemon.Stages[(int)Enum.stat.Evasion]) / getStageMultiplicator(attacker.Pokemon.Stages[(int)Enum.stat.Accuracy])) * otherMods;
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
        public int shakes(PocketMonster pokemon, double pokeballBonus)
        {
            int nbShake = 0;

            double a = ((3 * pokemon.HP - 2 * pokemon.CurrentHP) * Pokedex.getInfo(pokemon.PokedexID).CatchRate * pokeballBonus) / (3 * pokemon.HP);

            if (pokemon.Status == (int)Enum.status.Sleep || pokemon.Status == (int)Enum.status.Frozen)
                a *= 2;
            else if(pokemon.Status != 0)
                a *= 1.5;

            double shakeProbability = 1048560 / Math.Sqrt(Math.Sqrt(16711680 / a));


            bool stillGoing = true;

            while(stillGoing)
            {
                int check = Utilities.RandomNumber(0, 65536);
                if (check >= shakeProbability)
                    stillGoing = false;
                else
                    nbShake++;
                if(nbShake == 4)
                    stillGoing = false;
            }

            //If the nb < 3, then the pokemon has been catched !
            return nbShake;
        }
        public int calculXPGain(bool wildPokemon, PocketMonster foe)
        {
            double a;
            if (wildPokemon)
                a = 1;
            else
                a = 1.5;

            double experience = a * Pokedex.getInfo(foe.PokedexID).BaseExperienceYield * foe.Level/7;

            return (int)Math.Round(experience);
        }
    }
}

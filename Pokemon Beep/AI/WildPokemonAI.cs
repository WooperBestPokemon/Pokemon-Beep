using Pokemon_Beep.Pokemon;
using System.Collections.Generic;

namespace Pokemon_Beep.AI
{
    /// <summary>
    /// The wild pokemon has a very basic AI. If the defender has 10 % HP and lower, the wild pokemon will try to
    /// use a priority move that deal damage. If there aren't any priority move, it tries to use a damage dealing move.
    /// </summary>
    class WildPokemonAI
    {
        private PocketMonster pokemon;
        public WildPokemonAI(PocketMonster pokemon)
        {
            this.pokemon = pokemon;
        }
        public int getChoice(PocketMonster defender)
        {
            int choice;
            double percent = defender.currentHP / defender.HP * 100;

            if (percent <= 10)
            {
                if(hasDamagingMove())
                {
                    if (hasPriorityMove())
                        choice = priorityMoveChoice();
                    else
                        choice = damageMoveChoice();
                }
                else
                    choice = Utilities.RandomNumber(1, pokemon.Moveset.Count);
            }
            else
                choice = Utilities.RandomNumber(1, pokemon.Moveset.Count);
            return choice;
        }
        private bool hasPriorityMove()
        {
            bool priorityMove = false;

            for (int i = 0; i < pokemon.Moveset.Count; i++)
            {
                if (pokemon.Moveset[i].Priority > 0 && pokemon.Moveset[i].Power > 0)
                    priorityMove = true;
            }

            return priorityMove;
        }
        private bool hasDamagingMove()
        {
            bool damagingMove = false;

            for (int i = 0; i < pokemon.Moveset.Count; i++)
            {
                if (pokemon.Moveset[i].Power > 0)
                    damagingMove = true;
            }

            return damagingMove;
        }
        private int priorityMoveChoice()
        {
            List<int> priority = new List<int>();
            int choice = 0;
            for (int i = 0; i < pokemon.Moveset.Count; i++)
            {
                if (pokemon.Moveset[i].Priority > 0)
                    priority.Add(i);
            }
            int power = 0;
            for (int i = 0; i < priority.Count; i++)
            {
                if(pokemon.Moveset[priority[i]].Power > power)
                {
                    power = pokemon.Moveset[priority[i]].Power;
                    choice = priority[i];
                }
            }
            return choice;
        }
        private int damageMoveChoice()
        {
            List<int> damage = new List<int>();
            int choice;
            for (int i = 0; i < pokemon.Moveset.Count; i++)
            {
                if (pokemon.Moveset[i].Power > 0)
                    damage.Add(i);
            }
            if (damage.Count > 1)
                choice = damage[0];
            else
                choice = damage[Utilities.RandomNumber(1, damage.Count)];
            return choice;
        }
    }
}

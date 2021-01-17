using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Pokemon
{
    class Experience
    {
        public void getXP(PocketMonster pokemon, int amountXP)
        {
            pokemon.XP += amountXP;

            switch (Pokedex.getInfo(pokemon.PokedexID).Experience)
            {
                case (int)Enum.experience.Erratic:

                    while (pokemon.XP >= Erratic(pokemon.Level))
                        pokemon.levelUp();

                    break;
                case (int)Enum.experience.Fast:

                    while (pokemon.XP >= Fast(pokemon.Level))
                        pokemon.levelUp();

                    break;
                case (int)Enum.experience.Fluctuating:

                    while (pokemon.XP >= Fluctuating(pokemon.Level))
                        pokemon.levelUp();

                    break;
                case (int)Enum.experience.Medium_Fast:
                   
                    while (pokemon.XP >= MediumFast(pokemon.Level))
                        pokemon.levelUp();

                    break;
                case (int)Enum.experience.Medium_Slow:

                    while (pokemon.XP >= MediumSlow(pokemon.Level))
                        pokemon.levelUp();

                    break;
                case (int)Enum.experience.Slow:

                    while (pokemon.XP >= Slow(pokemon.Level))
                        pokemon.levelUp();

                    break;
            }
        }
        private int Erratic(int level)
        {
            if (level <= 50)
                return (int)Math.Floor(Math.Pow(level + 1, 3) * (100 - (level + 1)) / 50);
            else if (level <= 68)
                return (int)Math.Floor(Math.Pow(level + 1, 3) * (150 - (level + 1)) / 100);
            else if (level <= 98)
                return (int)Math.Floor(Math.Pow(level + 1, 3) * ((1911 - 10 * (level + 1)) / 3) / 500);
            else
                return (int)Math.Floor(Math.Pow(level + 1, 3) * (160 - (level + 1)) / 100);
        }
        private int Fast(int level)
        {  return (int)Math.Floor(4 * Math.Pow(level + 1, 3) / 5);  }
        private int MediumFast(int level)
        {  return (int)Math.Pow(level + 1, 3);  }
        private int MediumSlow(int level)
        { return (int)Math.Floor(1.2 * Math.Pow(level + 1, 3) - 15 * Math.Pow(level + 1, 2) + 100 * (level + 1) - 140); }
        private int Slow(int level)
        {  return (int)Math.Floor(5 * Math.Pow(level + 1, 3) / 4);  }
        private int Fluctuating(int level)
        {
            if (level <= 15)
                return (int)Math.Floor(Math.Pow(level + 1, 3) * ((((level + 2.0) / 3.0) + 24.0) / 50.0));
            else if (level <= 36)
                return (int)Math.Floor(Math.Pow(level + 1, 3) * (((level + 15.0) / 50.0)));
            else
                return (int)Math.Floor(Math.Pow(level + 1, 3) * ((((level + 1.0) / 2.0) + 32.0) / 50.0));
        }
    }
}

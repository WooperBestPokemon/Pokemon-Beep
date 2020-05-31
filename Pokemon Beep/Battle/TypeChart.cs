using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Battle
{
    class TypeChart
    {
        private enum type
        {
            Normal = 1,
            Fire = 2,
            Water = 3,
            Electric = 4,
            Grass = 5,
            Ice = 6,
            Fighting = 7,
            Poison = 8,
            Ground = 9,
            Fly = 10,
            Psy = 11,
            Bug = 12,
            Rock = 13,
            Ghost = 14,
            Dragon = 15,
            Dark = 16,
            Steel = 17,
            Fairy = 18
        }
        public double effectivity(int typeMove, PocketMonster defendingPokemon)
        {
            double effective = 1;
            //0 = NULL
            //0.25 = Almost no effect
            //0.5 = Not super effective
            //1 = Effective
            //2 = Super Effective
            //4 = Deadly Effective
            for (int i = 0; i < defendingPokemon.types.Count; i++)
            {
                if(effective != 0)
                {
                    //normal
                    if (typeMove == (int)type.Normal)
                    {
                        if (defendingPokemon.types[i] == (int)type.Ghost)
                            effective = 0;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                    }
                    //fire
                    else if (typeMove == (int)type.Fire)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Bug)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Dragon)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 2;
                    }
                    //water
                    else if (typeMove == (int)type.Water)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ground)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Dragon)
                            effective *= 0.5;
                    }
                    //Electric
                    else if (typeMove == (int)type.Electric)
                    {
                        if (defendingPokemon.types[i] == (int)type.Water)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Electric)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ground)
                            effective = 0;
                        else if (defendingPokemon.types[i] == (int)type.Fly)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Dragon)
                            effective *= 0.5;
                    }
                    //Grass
                    else if (typeMove == (int)type.Grass)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Water)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ground)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Fly)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Bug)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Dragon)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                    }
                    //Ice
                    else if (typeMove == (int)type.Ice)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ice)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ground)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Fly)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Dragon)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                    }
                    //Fighting
                    else if (typeMove == (int)type.Fighting)
                    {
                        if (defendingPokemon.types[i] == (int)type.Normal)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fly)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Psy)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Bug)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ghost)
                            effective = 0;
                        else if (defendingPokemon.types[i] == (int)type.Dark)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Fairy)
                            effective *= 0.5;
                    }
                    //Poison
                    else if (typeMove == (int)type.Poison)
                    {
                        if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ground)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ghost)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective = 0;
                        else if (defendingPokemon.types[i] == (int)type.Fairy)
                            effective *= 2;
                    }
                    //Ground
                    else if (typeMove == (int)type.Ground)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Electric)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Poison)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Fly)
                            effective = 0;
                        else if (defendingPokemon.types[i] == (int)type.Bug)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 2;
                    }
                    //Fly
                    else if (typeMove == (int)type.Fly)
                    {
                        if (defendingPokemon.types[i] == (int)type.Electric)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Fighting)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Bug)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                    }
                    //Psy
                    else if (typeMove == (int)type.Psy)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fighting)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Poison)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Psy)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Dark)
                            effective = 0;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                    }
                    //Bug
                    else if (typeMove == (int)type.Bug)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Fighting)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fly)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Psy)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ghost)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Dark)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fairy)
                            effective *= 0.5;
                    }
                    //Rock
                    else if(typeMove == (int)type.Rock)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Fighting)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ground)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fly)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Bug)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                    }
                    //Ghost
                    else if (typeMove == (int)type.Ghost)
                    {
                        if (defendingPokemon.types[i] == (int)type.Normal)
                            effective = 0;
                        else if (defendingPokemon.types[i] == (int)type.Psy)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ghost)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Dark)
                            effective *= 0.5;
                    }
                    //Dragon
                    else if (typeMove == (int)type.Dragon)
                    {
                        if (defendingPokemon.types[i] == (int)type.Dragon)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fairy)
                            effective = 0;
                    }
                    //Dark
                    else if (typeMove == (int)type.Dark)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fighting)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Psy)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Ghost)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Dark)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fairy)
                            effective *= 0.5;
                    }
                    //Steel
                    else if (typeMove == (int)type.Steel)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Electric)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fairy)
                            effective *= 2;
                    }
                    //Fairy
                    else if(typeMove == (int)type.Fairy)
                    {
                        if (defendingPokemon.types[i] == (int)type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Fighting)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.types[i] == (int)type.Dragon)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Dark)
                            effective *= 2;
                        else if (defendingPokemon.types[i] == (int)type.Steel)
                            effective *= 0.5;
                    }
                }               
            }
            return effective;
        }
    }
}

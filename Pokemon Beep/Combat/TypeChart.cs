using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Combat
{
    class TypeChart
    {
        public double effectivity(int typeMove, PocketMonster defendingPokemon)
        {
            double effective = 1;
            //0 = NULL
            //0.25 = Almost no effect
            //0.5 = Not super effective
            //1 = Effective
            //2 = Super Effective
            //4 = Deadly Effective
            for (int i = 0; i < defendingPokemon.Types.Count; i++)
            {
                if(effective != 0)
                {
                    //normal
                    if (typeMove == (int)Enum.type.Normal)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Ghost)
                            effective = 0;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                    }
                    //fire
                    else if (typeMove == (int)Enum.type.Fire)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Bug)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dragon)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 2;
                    }
                    //water
                    else if (typeMove == (int)Enum.type.Water)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ground)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dragon)
                            effective *= 0.5;
                    }
                    //Electric
                    else if (typeMove == (int)Enum.type.Electric)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Water)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Electric)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ground)
                            effective = 0;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fly)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dragon)
                            effective *= 0.5;
                    }
                    //Grass
                    else if (typeMove == (int)Enum.type.Grass)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Water)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ground)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fly)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Bug)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dragon)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                    }
                    //Ice
                    else if (typeMove == (int)Enum.type.Ice)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ice)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ground)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fly)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dragon)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                    }
                    //Fighting
                    else if (typeMove == (int)Enum.type.Fighting)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Normal)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fly)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Psy)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Bug)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ghost)
                            effective = 0;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dark)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fairy)
                            effective *= 0.5;
                    }
                    //Poison
                    else if (typeMove == (int)Enum.type.Poison)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ground)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ghost)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective = 0;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fairy)
                            effective *= 2;
                    }
                    //Ground
                    else if (typeMove == (int)Enum.type.Ground)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Electric)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Poison)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fly)
                            effective = 0;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Bug)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 2;
                    }
                    //Fly
                    else if (typeMove == (int)Enum.type.Fly)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Electric)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fighting)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Bug)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                    }
                    //Psy
                    else if (typeMove == (int)Enum.type.Psy)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fighting)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Poison)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Psy)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dark)
                            effective = 0;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                    }
                    //Bug
                    else if (typeMove == (int)Enum.type.Bug)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Grass)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fighting)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fly)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Psy)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ghost)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dark)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fairy)
                            effective *= 0.5;
                    }
                    //Rock
                    else if(typeMove == (int)Enum.type.Rock)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fighting)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ground)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fly)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Bug)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                    }
                    //Ghost
                    else if (typeMove == (int)Enum.type.Ghost)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Normal)
                            effective = 0;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Psy)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ghost)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dark)
                            effective *= 0.5;
                    }
                    //Dragon
                    else if (typeMove == (int)Enum.type.Dragon)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Dragon)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fairy)
                            effective = 0;
                    }
                    //Dark
                    else if (typeMove == (int)Enum.type.Dark)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fighting)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Psy)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ghost)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dark)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fairy)
                            effective *= 0.5;
                    }
                    //Steel
                    else if (typeMove == (int)Enum.type.Steel)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Water)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Electric)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Ice)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Rock)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fairy)
                            effective *= 2;
                    }
                    //Fairy
                    else if(typeMove == (int)Enum.type.Fairy)
                    {
                        if (defendingPokemon.Types[i] == (int)Enum.type.Fire)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Fighting)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Poison)
                            effective *= 0.5;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dragon)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Dark)
                            effective *= 2;
                        else if (defendingPokemon.Types[i] == (int)Enum.type.Steel)
                            effective *= 0.5;
                    }
                }               
            }
            return effective;
        }
    }
}

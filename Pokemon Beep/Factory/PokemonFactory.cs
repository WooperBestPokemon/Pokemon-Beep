using Pokemon_Beep.Battle;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class PokemonFactory
    {
        private AbilityFactory abilityFactory = new AbilityFactory();
        private MoveFactory moveFactory = new MoveFactory();
        private List<Ability> abilities;
        private List<Move> moves;
        public PokemonFactory()
        {
            moves = moveFactory.GetMoves();
            abilities = abilityFactory.GetAbilities();
        }
        public List<PocketMonster> GetPokemons()
        {
            List<PocketMonster> pokemons = new List<PocketMonster>();
            pokemons.Add(wooper());
            pokemons.Add(pachirisu());


            //TESTING-------------------------------------------------------
            
            /*---------------------------------------------------------------------------------------------------
            List<Ability> abilitiesChikorita = new List<Ability>();
            List<Learnset> learnsetChikorita = new List<Learnset>();
            abilitiesChikorita.Add(abilities[(int) Enum.ability.Overgrow]);
            abilitiesChikorita.Add(abilities[(int)Enum.ability.Leaf_Guard]);
            pokemons.Add(new PocketMonster(001, "Chikorita", "A sweet aroma gently wafts from the leaf on its head. It is docile and loves to soak up the sun's rays.", (int)Enum.gender.both, 0.9, 6.4, (int)Enum.colour.Green, (int)Enum.shape.Flower, (int)Enum.type.Grass, abilitiesChikorita, 45, (int)Enum.experience.Medium_Slow, 64, 45, 49, 65, 49, 65, 45, learnsetChikorita));
            */
            return pokemons;
        }
        PocketMonster wooper()
        {
            //General Information
            int pokedex = 001;
            string name = "Wooper";
            string description = "When walking on land, it covers its body with a poisonous film that keeps its skin from dehydrating.";
            int gender = (int)Enum.gender.Both;
            double height = 0.4;
            double weight = 8.5;
            int colour = (int)Enum.colour.Blue;
            int shape = (int)Enum.shape.Seal;           
            //Typing
            List<int> type = new List<int>();
            type.Add((int)Enum.type.Water);
            type.Add((int)Enum.type.Ground);
            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Damp]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Unaware]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Water_Absorb]);
            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> movesPokemon = new List<Move>();
            movesPokemon.Add(moves[(int) Enum.move.Tail_Whip]);
            movesPokemon.Add(moves[(int)Enum.move.Water_Gun]);
            movesPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            movesPokemon.Add(moves[(int)Enum.move.Mud_Shot]);

            movesPokemon.Add(moves[(int)Enum.move.Slam]);
            learnset.Add(new Learnset(movesPokemon[0], 1));
            learnset.Add(new Learnset(movesPokemon[1], 1));
            learnset.Add(new Learnset(movesPokemon[2], 4));
            learnset.Add(new Learnset(movesPokemon[3], 8));

            learnset.Add(new Learnset(movesPokemon[4], 16));
            //Battle
            int catchrate = 255;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 52;
            //Stats
            int baseHP = 55;
            int baseAttack = 45;
            int baseDefense = 45;
            int baseSpecialDefence = 25;
            int baseSpecialAttack = 25;
            int baseSpeed = 15;

            return new PocketMonster(pokedex, name, description, gender, height, weight, colour, shape, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefence, baseSpeed, learnset);
        }
        PocketMonster pachirisu()
        {
            //General Information
            int pokedex = 002;
            string name = "Pachirisu";
            string description = "It’s one of the kinds of Pokémon with electric cheek pouches. It shoots charges from its tail.";
            int gender = (int)Enum.gender.Both;
            double height = 0.4;
            double weight = 3.9;
            int colour = (int)Enum.colour.White;
            int shape = (int)Enum.shape.Bull;
            //Typing
            int type = (int)Enum.type.Electric;
            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Run_Away]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Pickup]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Volt_Absorb]);
            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> movesPokemon = new List<Move>();
            movesPokemon.Add(moves[0]);
            learnset.Add(new Learnset(movesPokemon[0], 1));
            //Battle
            int catchrate = 200;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 120;
            //Stats
            int baseHP = 60;
            int baseAttack = 45;
            int baseDefense = 70;
            int baseSpecialDefence = 45;
            int baseSpecialAttack = 90;
            int baseSpeed = 95;

            return new PocketMonster(pokedex, name, description, gender, height, weight, colour, shape, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefence, baseSpeed, learnset);
        }
    }
}

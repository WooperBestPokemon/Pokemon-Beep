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

            return pokemons;
        }

        public PocketMonster wooper()
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
            List<Move> movesPokemon = new List<Move>();
            movesPokemon.Add(moves[(int) Enum.move.Tail_Whip]);
            movesPokemon.Add(moves[(int)Enum.move.Water_Gun]);
            movesPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            movesPokemon.Add(moves[(int)Enum.move.Mud_Shot]);
            movesPokemon.Add(moves[(int)Enum.move.Haze]);
            movesPokemon.Add(moves[(int)Enum.move.Acid_Spray]);
            movesPokemon.Add(moves[(int)Enum.move.Slam]);
            movesPokemon.Add(moves[(int)Enum.move.Yawn]);
            movesPokemon.Add(moves[(int)Enum.move.Aqua_Tail]);
            //Learnset
            List<Learnset> learnset = new List<Learnset>();
            learnset.Add(new Learnset(movesPokemon[0], 1));
            learnset.Add(new Learnset(movesPokemon[1], 1));
            learnset.Add(new Learnset(movesPokemon[2], 4));
            learnset.Add(new Learnset(movesPokemon[3], 8));
            learnset.Add(new Learnset(movesPokemon[4], 12));
            learnset.Add(new Learnset(movesPokemon[5], 12));
            learnset.Add(new Learnset(movesPokemon[6], 16));
            learnset.Add(new Learnset(movesPokemon[7], 21));
            learnset.Add(new Learnset(movesPokemon[8], 24));

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
        public PocketMonster pachirisu()
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
            List<Move> movesPokemon = new List<Move>();
            //Leveling
            movesPokemon.Add(moves[(int)Enum.move.Growl]);
            movesPokemon.Add(moves[(int)Enum.move.Quick_Attack]);
            movesPokemon.Add(moves[(int)Enum.move.Charm]);
            movesPokemon.Add(moves[(int)Enum.move.Spark]);
            movesPokemon.Add(moves[(int)Enum.move.Endure]);
            movesPokemon.Add(moves[(int)Enum.move.Nuzzle]);
            movesPokemon.Add(moves[(int)Enum.move.Swift]);
            movesPokemon.Add(moves[(int)Enum.move.Electro_Ball]);
            movesPokemon.Add(moves[(int)Enum.move.Sweet_Kiss]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            movesPokemon.Add(moves[(int)Enum.move.Super_Fang]);
            movesPokemon.Add(moves[(int)Enum.move.Discharge]);
            movesPokemon.Add(moves[(int)Enum.move.Iron_Tail]);
            movesPokemon.Add(moves[(int)Enum.move.Hyper_Fang]);

            //TM
            movesPokemon.Add(moves[(int)Enum.move.Toxic]);
            //movesPokemon.Add(moves[(int)Enum.move.Hidden_Power]);
            //movesPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            movesPokemon.Add(moves[(int)Enum.move.Protect]);
            movesPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            movesPokemon.Add(moves[(int)Enum.move.Thunderbold]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder]);
            //movesPokemon.Add(moves[(int)Enum.move.Double_Team]);
            //movesPokemon.Add(moves[(int)Enum.move.Facade]);
            //movesPokemon.Add(moves[(int)Enum.move.Rest]);
            //movesPokemon.Add(moves[(int)Enum.move.Attract]);
            //movesPokemon.Add(moves[(int)Enum.move.Round]);
            //movesPokemon.Add(moves[(int)Enum.move.Echoed_Voice]);
            //movesPokemon.Add(moves[(int)Enum.move.Fling]);
            //movesPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            //movesPokemon.Add(moves[(int)Enum.move.Volt_Switch]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            //movesPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            //movesPokemon.Add(moves[(int)Enum.move.Swagger]);
            //movesPokemon.Add(moves[(int)Enum.move.Sleep_Talk]);
            //movesPokemon.Add(moves[(int)Enum.move.U_turn]);
            //movesPokemon.Add(moves[(int)Enum.move.Substitute]);
            //movesPokemon.Add(moves[(int)Enum.move.Confide]);

            //Learnset
            List<Learnset> learnset = new List<Learnset>();
            learnset.Add(new Learnset(movesPokemon[0], 1));
            learnset.Add(new Learnset(movesPokemon[1], 5));
            learnset.Add(new Learnset(movesPokemon[2], 9));
            learnset.Add(new Learnset(movesPokemon[3], 13));
            learnset.Add(new Learnset(movesPokemon[4], 17));
            learnset.Add(new Learnset(movesPokemon[5], 19));
            learnset.Add(new Learnset(movesPokemon[6], 21));
            learnset.Add(new Learnset(movesPokemon[7], 25));
            learnset.Add(new Learnset(movesPokemon[8], 29));
            learnset.Add(new Learnset(movesPokemon[9], 33));
            learnset.Add(new Learnset(movesPokemon[10], 37));
            learnset.Add(new Learnset(movesPokemon[11], 41));
            learnset.Add(new Learnset(movesPokemon[12], 45));
            learnset.Add(new Learnset(movesPokemon[13], 49));

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

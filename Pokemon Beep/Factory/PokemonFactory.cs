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
            pokemons.Add(Pachirisu());

            //sorting by Pokedex
            pokemons = pokemons.OrderBy(q => q.PokedexID).ToList();

            return pokemons;
        }
        /*
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
        */
        public PocketMonster Rattata()
        {
            //General Information
            int pokedex = 010;
            string name = "Rattata";
            string description = "Living wherever there is food available, it ceaselessly scavenges for edibles the entire day.";
            int gender = (int)Enum.gender.Both;
            double height = 0.3;
            double weight = 3.5;
            int colour = (int)Enum.colour.Purple;
            int shape = (int)Enum.shape.Bull;

            //Typing
            int type = (int)Enum.type.Normal;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Run_Away]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Guts]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Hustle]);

            //Stats
            int baseHP = 30;
            int baseAttack = 56;
            int baseDefense = 35;
            int baseSpecialAttack = 25;
            int baseSpecialDefense = 35;
            int baseSpeed = 72;

            //Battle
            int catchrate = 255;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 57;

            //Moves
            List<Move> movesPokemon = new List<Move>();
            //========================================================Leveling
            movesPokemon.Add(moves[(int)Enum.move.Tackle]);
            movesPokemon.Add(moves[(int)Enum.move.Tail_Whip]);
            movesPokemon.Add(moves[(int)Enum.move.Quick_Attack]);
            movesPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            movesPokemon.Add(moves[(int)Enum.move.Bite]);
            movesPokemon.Add(moves[(int)Enum.move.Super_Fang]);
            movesPokemon.Add(moves[(int)Enum.move.Crunch]);
            movesPokemon.Add(moves[(int)Enum.move.Hyper_Fang]);
            movesPokemon.Add(moves[(int)Enum.move.Sucker_Punch]);
            movesPokemon.Add(moves[(int)Enum.move.Double_Edge]);
            //=======================================================TM
            movesPokemon.Add(moves[(int)Enum.move.Headbutt]);
            //movesPokemon.Add(moves[(int)Enum.move.Taunt]);
            //movesPokemon.Add(moves[(int)Enum.move.Rest]);
            movesPokemon.Add(moves[(int)Enum.move.Protect]);
            //movesPokemon.Add(moves[(int)Enum.move.Substitute]);
            //movesPokemon.Add(moves[(int)Enum.move.Dig]);
            //movesPokemon.Add(moves[(int)Enum.move.Facade]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            //movesPokemon.Add(moves[(int)Enum.move.U_turn]);
            movesPokemon.Add(moves[(int)Enum.move.Iron_Tail]);
            movesPokemon.Add(moves[(int)Enum.move.Toxic]);
            movesPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder]);
            movesPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            movesPokemon.Add(moves[(int)Enum.move.Blizzard]);
            movesPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            //=======================================================Learnset
            List<Learnset> learnset = new List<Learnset>();
            learnset.Add(new Learnset(movesPokemon[0], 1));
            learnset.Add(new Learnset(movesPokemon[1], 3));
            learnset.Add(new Learnset(movesPokemon[2], 6));
            learnset.Add(new Learnset(movesPokemon[3], 9));
            learnset.Add(new Learnset(movesPokemon[4], 12));
            learnset.Add(new Learnset(movesPokemon[5], 15));
            learnset.Add(new Learnset(movesPokemon[6], 18));
            learnset.Add(new Learnset(movesPokemon[7], 21));
            learnset.Add(new Learnset(movesPokemon[8], 24));
            learnset.Add(new Learnset(movesPokemon[9], 27));

            return new PocketMonster(pokedex, name, description, gender, height, weight, colour, shape, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, movesPokemon, learnset, Raticate(), 20);
        }
        public PocketMonster Raticate()
        {
            //General Information
            int pokedex = 011;
            string name = "Raticate";
            string description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.";
            int gender = (int)Enum.gender.Both;
            double height = 0.7;
            double weight = 18.5;
            int colour = (int)Enum.colour.Brown;
            int shape = (int)Enum.shape.Bull;

            //Typing
            int type = (int)Enum.type.Normal;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Run_Away]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Guts]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Hustle]);

            //Battle
            int catchrate = 200;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 127;

            //Stats
            int baseHP = 55;
            int baseAttack = 81;
            int baseDefense = 60;
            int baseSpecialAttack = 50;
            int baseSpecialDefense = 70;
            int baseSpeed = 97;

            //Moves
            List<Move> movesPokemon = new List<Move>();
            //========================================================Leveling
            movesPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            movesPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            movesPokemon.Add(moves[(int)Enum.move.Tackle]);
            movesPokemon.Add(moves[(int)Enum.move.Tail_Whip]);
            movesPokemon.Add(moves[(int)Enum.move.Quick_Attack]);
            movesPokemon.Add(moves[(int)Enum.move.Bite]);
            movesPokemon.Add(moves[(int)Enum.move.Super_Fang]);
            movesPokemon.Add(moves[(int)Enum.move.Crunch]);
            movesPokemon.Add(moves[(int)Enum.move.Hyper_Fang]);
            movesPokemon.Add(moves[(int)Enum.move.Sucker_Punch]);
            movesPokemon.Add(moves[(int)Enum.move.Double_Edge]);
            //========================================================TM
            movesPokemon.Add(moves[(int)Enum.move.Headbutt]);
            //movesPokemon.Add(moves[(int)Enum.move.Taunt]);
            //movesPokemon.Add(moves[(int)Enum.move.Rest]);
            movesPokemon.Add(moves[(int)Enum.move.Protect]);
            //movesPokemon.Add(moves[(int)Enum.move.Substitute]);
            //movesPokemon.Add(moves[(int)Enum.move.Dig]);
            //movesPokemon.Add(moves[(int)Enum.move.Facade]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            //movesPokemon.Add(moves[(int)Enum.move.U_turn]);
            movesPokemon.Add(moves[(int)Enum.move.Iron_Tail]);
            movesPokemon.Add(moves[(int)Enum.move.Toxic]);
            movesPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder]);
            movesPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            movesPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            movesPokemon.Add(moves[(int)Enum.move.Blizzard]);
            movesPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            //========================================================Learnset
            List<Learnset> learnset = new List<Learnset>();
            learnset.Add(new Learnset(movesPokemon[0], 1));
            learnset.Add(new Learnset(movesPokemon[1], 1));
            learnset.Add(new Learnset(movesPokemon[2], 1));
            learnset.Add(new Learnset(movesPokemon[3], 3));
            learnset.Add(new Learnset(movesPokemon[4], 6));
            learnset.Add(new Learnset(movesPokemon[5], 12));
            learnset.Add(new Learnset(movesPokemon[6], 15));
            learnset.Add(new Learnset(movesPokemon[7], 18));
            learnset.Add(new Learnset(movesPokemon[8], 26));
            learnset.Add(new Learnset(movesPokemon[9], 34));
            learnset.Add(new Learnset(movesPokemon[10], 42));

            return new PocketMonster(pokedex, name, description, gender, height, weight, colour, shape, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, movesPokemon, learnset);
        }
        public PocketMonster Furret()
        {
            //General Information
            int pokedex = 013;
            string name = "Furret";
            string description = "Furret is a POKéMON that loves walking around all kind of places.";
            int gender = (int)Enum.gender.Both;
            double height = 1.8;
            double weight = 32.5;
            int colour = (int)Enum.colour.Brown;
            int shape = (int)Enum.shape.Bull;

            //Typing
            int type = (int)Enum.type.Normal;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Run_Away]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Keen_Eye]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Frisk]);

            //Stats
            int baseHP = 85;
            int baseAttack = 76;
            int baseDefense = 64;
            int baseSpecialAttack = 45;
            int baseSpecialDefense = 55;
            int baseSpeed = 90;

            //Battle
            int catchrate = 90;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 116;

            //Moves
            List<Move> movesPokemon = new List<Move>();
            //========================================================Leveling
            movesPokemon.Add(moves[(int)Enum.move.Agility]);
            //movesPokemon.Add(moves[(int)Enum.move.Coil]);
            movesPokemon.Add(moves[(int)Enum.move.Defense_Curl]);
            movesPokemon.Add(moves[(int)Enum.move.Charm]);
            movesPokemon.Add(moves[(int)Enum.move.Quick_Attack]);
            movesPokemon.Add(moves[(int)Enum.move.Scratch]);
            movesPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            movesPokemon.Add(moves[(int)Enum.move.Charm]);
            movesPokemon.Add(moves[(int)Enum.move.Swift]);
            movesPokemon.Add(moves[(int)Enum.move.Slam]);
            //movesPokemon.Add(moves[(int)Enum.move.Rest]);
            movesPokemon.Add(moves[(int)Enum.move.Sucker_Punch]);
            movesPokemon.Add(moves[(int)Enum.move.Amnesia]);
            //movesPokemon.Add(moves[(int)Enum.move.Baton_Pass]);
            //movesPokemon.Add(moves[(int)Enum.move.Me_First]);
            movesPokemon.Add(moves[(int)Enum.move.Hyper_Voice]);
            //=======================================================TM
            //movesPokemon.Add(moves[(int)Enum.move.Work_Up]);
            movesPokemon.Add(moves[(int)Enum.move.Toxic]);
            movesPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            movesPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            movesPokemon.Add(moves[(int)Enum.move.Blizzard]);
            movesPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            movesPokemon.Add(moves[(int)Enum.move.Protect]);
            movesPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //movesPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            movesPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder]);
            movesPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            //movesPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            //movesPokemon.Add(moves[(int)Enum.move.Double_Team]);
            movesPokemon.Add(moves[(int)Enum.move.Flamethrower]);
            //movesPokemon.Add(moves[(int)Enum.move.Facade]);
            //movesPokemon.Add(moves[(int)Enum.move.Rest]);
            //movesPokemon.Add(moves[(int)Enum.move.Attract]);
            //movesPokemon.Add(moves[(int)Enum.move.Thief]);
            movesPokemon.Add(moves[(int)Enum.move.Focus_Blast]);
            movesPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            //movesPokemon.Add(moves[(int)Enum.move.Brutal_Swing]);
            //movesPokemon.Add(moves[(int)Enum.move.Shadow_Claw]);
            movesPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            //movesPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            //movesPokemon.Add(moves[(int)Enum.move.Swagger]);
            //movesPokemon.Add(moves[(int)Enum.move.Sleep_Talk]);
            //movesPokemon.Add(moves[(int)Enum.move.U_Turn]);
            //movesPokemon.Add(moves[(int)Enum.move.Substitute]);
            //movesPokemon.Add(moves[(int)Enum.move.Surf]);
            //movesPokemon.Add(moves[(int)Enum.move.Confide]);
            //=======================================================Learnset
            List<Learnset> learnset = new List<Learnset>();
            learnset.Add(new Learnset(movesPokemon[0], 1));
            //learnset.Add(new Learnset(movesPokemon[1], 1));
            //learnset.Add(new Learnset(movesPokemon[2], 1));
            //learnset.Add(new Learnset(movesPokemon[3], 1));
            //learnset.Add(new Learnset(movesPokemon[4], 1));
            //learnset.Add(new Learnset(movesPokemon[5], 1));
            //learnset.Add(new Learnset(movesPokemon[6], 13));
            //learnset.Add(new Learnset(movesPokemon[7], 17));
            //learnset.Add(new Learnset(movesPokemon[8], 21));
            //learnset.Add(new Learnset(movesPokemon[9], 28));
            //learnset.Add(new Learnset(movesPokemon[10], 32));
            //learnset.Add(new Learnset(movesPokemon[11], 36));
            //learnset.Add(new Learnset(movesPokemon[12], 42));
            //learnset.Add(new Learnset(movesPokemon[13], 46));
            //learnset.Add(new Learnset(movesPokemon[14], 50));
            //learnset.Add(new Learnset(movesPokemon[15], 56));

            return new PocketMonster(pokedex, name, description, gender, height, weight, colour, shape, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, movesPokemon, learnset);
        }
        public PocketMonster Pachirisu()
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

            //Stats
            int baseHP = 60;
            int baseAttack = 45;
            int baseDefense = 70;
            int baseSpecialAttack = 45;
            int baseSpecialDefense = 90;
            int baseSpeed = 95;

            //Battle
            int catchrate = 200;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 120;

            //Moves
            List<Move> movesPokemon = new List<Move>();
            //========================================================Leveling
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
            //========================================================TM
            movesPokemon.Add(moves[(int)Enum.move.Toxic]);
            //movesPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            movesPokemon.Add(moves[(int)Enum.move.Protect]);
            movesPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            movesPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder]);
            //movesPokemon.Add(moves[(int)Enum.move.Double_Team]);
            //movesPokemon.Add(moves[(int)Enum.move.Facade]);
            //movesPokemon.Add(moves[(int)Enum.move.Rest]);
            //movesPokemon.Add(moves[(int)Enum.move.Attract]);
            //movesPokemon.Add(moves[(int)Enum.move.Round]);
            //movesPokemon.Add(moves[(int)Enum.move.Echoed_Voice]);
            //movesPokemon.Add(moves[(int)Enum.move.Fling]);
            movesPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            //movesPokemon.Add(moves[(int)Enum.move.Volt_Switch]);
            movesPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            //movesPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            //movesPokemon.Add(moves[(int)Enum.move.Swagger]);
            //movesPokemon.Add(moves[(int)Enum.move.Sleep_Talk]);
            //movesPokemon.Add(moves[(int)Enum.move.U_turn]);
            //movesPokemon.Add(moves[(int)Enum.move.Substitute]);
            //movesPokemon.Add(moves[(int)Enum.move.Confide]);
            //========================================================Learnset
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

            return new PocketMonster(pokedex, name, description, gender, height, weight, colour, shape, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, movesPokemon, learnset);
        }
    }
}

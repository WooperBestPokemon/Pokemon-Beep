using Pokemon_Beep.Combat;
using Pokemon_Beep.Pokemon;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Beep.Factory
{
    class PokemonFactory
    {
        private List<PokemonInfo> PokemonList = new List<PokemonInfo>();
        private AbilityFactory abilityFactory = new AbilityFactory();
        private MoveFactory moveFactory = new MoveFactory();
        private List<Ability> abilities;
        private List<Move> moves;
        public PokemonFactory()
        {
            moves = moveFactory.GetMoves();
            abilities = abilityFactory.GetAbilities();
            PokemonList = GetPokemons();

        }
        public PokemonInfo getPokemon(int pokedexID)
        {
            return PokemonList[pokedexID - 1];
        }
        private List<PokemonInfo> GetPokemons()
        {
            List<PokemonInfo> pokemons = new List<PokemonInfo>();
            pokemons.Add(Chikorita());
            pokemons.Add(Bayleef());
            pokemons.Add(Meganium());
            pokemons.Add(Cyndaquil());
            pokemons.Add(Quilava());
            pokemons.Add(Typhlosion()); 
            pokemons.Add(Totodile());
            pokemons.Add(Croconaw());
            pokemons.Add(Feraligatr());
            pokemons.Add(Rattata());
            pokemons.Add(Raticate());
            pokemons.Add(Sentret());
            pokemons.Add(Furret());

            //sorting by Pokedex
            pokemons = pokemons.OrderBy(q => q.PokedexID).ToList();

            return pokemons;
        }
        /*
        public PokemonInfo getPokemon(int PokemonInfo)
        {
            
            PokemonInfo pokemon;
            switch(PokemonInfo)
            {
                case 1:
                    pokemon = Chikorita();
                    break;
                case 2:
                    pokemon = Bayleef();
                    break;
                case 3:
                    pokemon = Meganium();
                    break;
                default:
                    pokemon = MissingNo();
                    break;
            }
            return pokemon;
            
        }
        */
        /*
        public PocketMonster Wooper()
        {
            //General Information
            int pokedex = 001;
            string name = "Wooper";
            string description = "When walking on land, it covers its body with a poisonous film that keeps its skin from dehydrating.";
            int gender = (int)Enum.gender.Both;
            double height = 0.4;
            double weight = 8.5;         
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

            return new PocketMonster(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefence, baseSpeed, learnset);
        }
        */
        private PokemonInfo MissingNo()
        {
            //General Information
            int pokedex = 000;
            string name = "MissingNo";
            string description = "";
            int gender = (int)Enum.gender.Both;
            double height = 0;
            double weight = 0;

            //Typing
            int type = (int)Enum.type.Fly;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Torrent]);

            //Stats
            int baseHP = 50;
            int baseAttack = 65;
            int baseDefense = 64;
            int baseSpecialAttack = 44;
            int baseSpecialDefense = 48;
            int baseSpeed = 100;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 63;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Crunch], 1));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Leer]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo testing()
        {
            //General Information
            int pokedex = 000;
            string name = "14-S";
            string description = "";
            int gender = (int)Enum.gender.Both;
            double height = 0;
            double weight = 0;

            //Typing
            int type = (int)Enum.type.Fly;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Torrent]);

            //Stats
            int baseHP = 50;
            int baseAttack = 65;
            int baseDefense = 64;
            int baseSpecialAttack = 44;
            int baseSpecialDefense = 48;
            int baseSpeed = 43;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 63;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Crunch], 1));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Leer]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        //---------------------------------------------------------
        private PokemonInfo Chikorita()
        {
            //General Information
            int pokedex = 001;
            string name = "Chikorita";
            string description = "It uses the leaf on its head to determine the temperature and humidity. It loves to sunbathe.";
            int gender = (int)Enum.gender.Both;
            double height = 0.9;
            double weight = 6.4;

            //Typing
            int type = (int)Enum.type.Grass;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Overgrow]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Leaf_Guard]);

            //Stats
            int baseHP = 45;
            int baseAttack = 49;
            int baseDefense = 65;
            int baseSpecialAttack = 49;
            int baseSpecialDefense = 65;
            int baseSpeed = 45;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 64;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Razor_Leaf], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Poison_Powder], 9));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Synthesis], 12));
            learnset.Add(new Learnset(moves[(int)Enum.move.Reflect], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Magical_Leaf], 20));
            learnset.Add(new Learnset(moves[(int)Enum.move.Petal_Dance], 23));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sweet_Scent], 28));
            learnset.Add(new Learnset(moves[(int)Enum.move.Light_Screen], 31));
            learnset.Add(new Learnset(moves[(int)Enum.move.Body_Slam], 34));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Safeguard], 39));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aromatherapy], 42));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Solar_Beam], 45));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Safeguard]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Reflect]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Energy_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Flash]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Ancient_Power]);
            tmPokemon.Add(moves[(int)Enum.move.Aromatherapy]);
            tmPokemon.Add(moves[(int)Enum.move.Body_Slam]);
            //tmPokemon.Add(moves[(int)Enum.move.Counter]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Whistle]);
            //tmPokemon.Add(moves[(int)Enum.move.Heal_Pulse]);
            //tmPokemon.Add(moves[(int)Enum.move.Ingrain]);
            //tmPokemon.Add(moves[(int)Enum.move.Leaf_Storm]);
            tmPokemon.Add(moves[(int)Enum.move.Leech_Seed]);
            //tmPokemon.Add(moves[(int)Enum.move.Refresh]);
            tmPokemon.Add(moves[(int)Enum.move.Vine_Whip]);
            //tmPokemon.Add(moves[(int)Enum.move.Wring_Out]);

            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Bayleef(), 16);
        }
        private PokemonInfo Bayleef()
        {
            //General Information
            int pokedex = 002;
            string name = "Bayleef";
            string description = "The buds that ring its neck give off a spicy aroma that perks people up.";
            int gender = (int)Enum.gender.Both;
            double height = 1.2;
            double weight = 15.8;

            //Typing
            int type = (int)Enum.type.Grass;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Overgrow]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Leaf_Guard]);

            //Stats
            int baseHP = 60;
            int baseAttack = 62;
            int baseDefense = 80;
            int baseSpecialAttack = 63;
            int baseSpecialDefense = 80;
            int baseSpeed = 60;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 142;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Razor_Leaf], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Poison_Powder], 9));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Synthesis], 12));
            learnset.Add(new Learnset(moves[(int)Enum.move.Reflect], 18));
            learnset.Add(new Learnset(moves[(int)Enum.move.Magical_Leaf], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Petal_Dance], 26));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sweet_Scent], 32));
            learnset.Add(new Learnset(moves[(int)Enum.move.Light_Screen], 34));
            learnset.Add(new Learnset(moves[(int)Enum.move.Body_Slam], 40));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Safeguard], 46));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aromatherapy], 50));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Solar_Beam], 54));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Safeguard]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Reflect]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Energy_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Flash]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);

            tmPokemon.Add(moves[(int)Enum.move.Ancient_Power]);
            tmPokemon.Add(moves[(int)Enum.move.Aromatherapy]);
            tmPokemon.Add(moves[(int)Enum.move.Body_Slam]);
            //tmPokemon.Add(moves[(int)Enum.move.Counter]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Whistle]);
            //tmPokemon.Add(moves[(int)Enum.move.Heal_Pulse]);
            //tmPokemon.Add(moves[(int)Enum.move.Ingrain]);
            //tmPokemon.Add(moves[(int)Enum.move.Leaf_Storm]);
            tmPokemon.Add(moves[(int)Enum.move.Leech_Seed]);
            //tmPokemon.Add(moves[(int)Enum.move.Refresh]);
            tmPokemon.Add(moves[(int)Enum.move.Vine_Whip]);
            //tmPokemon.Add(moves[(int)Enum.move.Wring_Out]);

            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Meganium(), 32);
        }
        private PokemonInfo Meganium()
        {
            //General Information
            int pokedex = 003;
            string name = "Meganium";
            string description = "Its breath has the fantastic ability to revive dead plants and flowers.";
            int gender = (int)Enum.gender.Both;
            double height = 1.8;
            double weight = 100.5;

            //Typing
            int type = (int)Enum.type.Grass;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Overgrow]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Leaf_Guard]);

            //Stats
            int baseHP = 80;
            int baseAttack = 82;
            int baseDefense = 100;
            int baseSpecialAttack = 83;
            int baseSpecialDefense = 100;
            int baseSpeed = 80;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 236;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Razor_Leaf], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Poison_Powder], 9));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Synthesis], 12));
            learnset.Add(new Learnset(moves[(int)Enum.move.Reflect], 18));
            learnset.Add(new Learnset(moves[(int)Enum.move.Magical_Leaf], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Petal_Dance], 26));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sweet_Scent], 32));
            learnset.Add(new Learnset(moves[(int)Enum.move.Light_Screen], 34));
            learnset.Add(new Learnset(moves[(int)Enum.move.Body_Slam], 40));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Safeguard], 46));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aromatherapy], 54));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Solar_Beam], 60));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Safeguard]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            //tmPokemon.Add(moves[(int)Enum.move.Earthquake]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Reflect]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Energy_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Flash]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Bulldoze]);
            //tmPokemon.Add(moves[(int)Enum.move.Dragon_Tail]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);

            tmPokemon.Add(moves[(int)Enum.move.Ancient_Power]);
            tmPokemon.Add(moves[(int)Enum.move.Aromatherapy]);
            tmPokemon.Add(moves[(int)Enum.move.Body_Slam]);
            //tmPokemon.Add(moves[(int)Enum.move.Counter]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Whistle]);
            //tmPokemon.Add(moves[(int)Enum.move.Heal_Pulse]);
            //tmPokemon.Add(moves[(int)Enum.move.Ingrain]);
            //tmPokemon.Add(moves[(int)Enum.move.Leaf_Storm]);
            tmPokemon.Add(moves[(int)Enum.move.Leech_Seed]);
            //tmPokemon.Add(moves[(int)Enum.move.Refresh]);
            tmPokemon.Add(moves[(int)Enum.move.Vine_Whip]);
            //tmPokemon.Add(moves[(int)Enum.move.Wring_Out]);

            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Cyndaquil()
        {
            //General Information
            int pokedex = 004;
            string name = "Cyndaquil";
            string description = "It has a timid nature. If it is startled, the flames on its back burn more vigorously.";
            int gender = (int)Enum.gender.Both;
            double height = 0.5;
            double weight = 7.9;

            //Typing
            int type = (int)Enum.type.Fire;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Blaze]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Flash_Fire]);

            //Stats
            int baseHP = 39;
            int baseAttack = 52;
            int baseDefense = 43;
            int baseSpecialAttack = 60;
            int baseSpecialDefense = 50;
            int baseSpeed = 65;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 62;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Smokescreen], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Ember], 10));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flame_Wheel], 19));
            learnset.Add(new Learnset(moves[(int)Enum.move.Defense_Curl], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Swift], 28));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flame_Charge], 31));
            learnset.Add(new Learnset(moves[(int)Enum.move.Lava_Plume], 37));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flamethrower], 40));
            learnset.Add(new Learnset(moves[(int)Enum.move.Inferno], 46));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Rollout], 49));
            learnset.Add(new Learnset(moves[(int)Enum.move.Double_Edge], 55));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Eruption], 58));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Flamethrower]);
            tmPokemon.Add(moves[(int)Enum.move.Fire_Blast]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Flame_Charge]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Overheat]);
            //tmPokemon.Add(moves[(int)Enum.move.Incinerate]);
            tmPokemon.Add(moves[(int)Enum.move.Will_O_Wisp]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Wild_Charge]);
            //tmPokemon.Add(moves[(int)Enum.move.Covet]);
            tmPokemon.Add(moves[(int)Enum.move.Crush_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Double_Kick]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Edge]);
            tmPokemon.Add(moves[(int)Enum.move.Extrasensory]);
            //tmPokemon.Add(moves[(int)Enum.move.Flame_Burst]);
            tmPokemon.Add(moves[(int)Enum.move.Flare_Blitz]);
            //tmPokemon.Add(moves[(int)Enum.move.Foresight]);
            tmPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            //tmPokemon.Add(moves[(int)Enum.move.Howl]);
            tmPokemon.Add(moves[(int)Enum.move.Quick_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Reversal]);
            tmPokemon.Add(moves[(int)Enum.move.Thrash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Quilava(), 14);
        }
        private PokemonInfo Quilava()
        {
            //General Information
            int pokedex = 005;
            string name = "Quilava";
            string description = "It intimidates foes with the heat of its flames. The fire burns more strongly when it readies to fight.";
            int gender = (int)Enum.gender.Both;
            double height = 0.9;
            double weight = 19;

            //Typing
            int type = (int)Enum.type.Fire;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Blaze]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Flash_Fire]);

            //Stats
            int baseHP = 58;
            int baseAttack = 64;
            int baseDefense = 58;
            int baseSpecialAttack = 80;
            int baseSpecialDefense = 65;
            int baseSpeed = 80;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 142;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Smokescreen], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Ember], 10));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flame_Wheel], 20));
            learnset.Add(new Learnset(moves[(int)Enum.move.Defense_Curl], 24));
            learnset.Add(new Learnset(moves[(int)Enum.move.Swift], 31));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flame_Charge], 35));
            learnset.Add(new Learnset(moves[(int)Enum.move.Lava_Plume], 42));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flamethrower], 46));
            learnset.Add(new Learnset(moves[(int)Enum.move.Inferno], 53));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Rollout], 57));
            learnset.Add(new Learnset(moves[(int)Enum.move.Double_Edge], 64));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Eruption], 68));
            //========================================================TM
            //tmPokemon.Add(moves[(int)Enum.move.Roar]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Flamethrower]);
            tmPokemon.Add(moves[(int)Enum.move.Fire_Blast]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Flame_Charge]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Overheat]);
            //tmPokemon.Add(moves[(int)Enum.move.Incinerate]);
            tmPokemon.Add(moves[(int)Enum.move.Will_O_Wisp]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Wild_Charge]);

            //tmPokemon.Add(moves[(int)Enum.move.Covet]);
            tmPokemon.Add(moves[(int)Enum.move.Crush_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Double_Kick]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Edge]);
            tmPokemon.Add(moves[(int)Enum.move.Extrasensory]);
            //tmPokemon.Add(moves[(int)Enum.move.Flame_Burst]);
            tmPokemon.Add(moves[(int)Enum.move.Flare_Blitz]);
            //tmPokemon.Add(moves[(int)Enum.move.Foresight]);
            tmPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            //tmPokemon.Add(moves[(int)Enum.move.Howl]);
            tmPokemon.Add(moves[(int)Enum.move.Quick_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Reversal]);
            tmPokemon.Add(moves[(int)Enum.move.Thrash]);

            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Typhlosion(), 36);
        }
        private PokemonInfo Typhlosion()
        {
            //General Information
            int pokedex = 006;
            string name = "Typhlosion";
            string description = "It attacks using blasts of fire. It creates heat shimmers with intense fire to hide itself.";
            int gender = (int)Enum.gender.Both;
            double height = 1.7;
            double weight = 79.5;

            //Typing
            int type = (int)Enum.type.Fire;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Blaze]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Flash_Fire]);

            //Stats
            int baseHP = 78;
            int baseAttack = 84;
            int baseDefense = 78;
            int baseSpecialAttack = 109;
            int baseSpecialDefense = 85;
            int baseSpeed = 100;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 240;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            //learnset.Add(new Learnset(moves[(int)Enum.move.Gyro_Ball], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Smokescreen], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Ember], 10));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flame_Wheel], 20));
            learnset.Add(new Learnset(moves[(int)Enum.move.Defense_Curl], 24));
            learnset.Add(new Learnset(moves[(int)Enum.move.Swift], 31));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flame_Charge], 35));
            learnset.Add(new Learnset(moves[(int)Enum.move.Lava_Plume], 43));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flamethrower], 48));
            learnset.Add(new Learnset(moves[(int)Enum.move.Inferno], 56));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Rollout], 61));
            learnset.Add(new Learnset(moves[(int)Enum.move.Double_Edge], 69));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Eruption], 74));
            //========================================================TM
            //tmPokemon.Add(moves[(int)Enum.move.Roar]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            //tmPokemon.Add(moves[(int)Enum.move.Earthquake]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Flamethrower]);
            tmPokemon.Add(moves[(int)Enum.move.Fire_Blast]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Tomb]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Flame_Charge]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Overheat]);
            tmPokemon.Add(moves[(int)Enum.move.Focus_Blast]);
            //tmPokemon.Add(moves[(int)Enum.move.Fling]);
            //tmPokemon.Add(moves[(int)Enum.move.Incinerate]);
            tmPokemon.Add(moves[(int)Enum.move.Will_O_Wisp]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Claw]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            //tmPokemon.Add(moves[(int)Enum.move.Gyro_Ball]);
            //tmPokemon.Add(moves[(int)Enum.move.Bulldoze]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Slide]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Wild_Charge]);

            //tmPokemon.Add(moves[(int)Enum.move.Covet]);
            tmPokemon.Add(moves[(int)Enum.move.Crush_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Double_Kick]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Edge]);
            tmPokemon.Add(moves[(int)Enum.move.Extrasensory]);
            //tmPokemon.Add(moves[(int)Enum.move.Flame_Burst]);
            tmPokemon.Add(moves[(int)Enum.move.Flare_Blitz]);
            //tmPokemon.Add(moves[(int)Enum.move.Foresight]);
            tmPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            tmPokemon.Add(moves[(int)Enum.move.Howl]);
            tmPokemon.Add(moves[(int)Enum.move.Quick_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Reversal]);
            tmPokemon.Add(moves[(int)Enum.move.Thrash]);

            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Totodile()
        {
            //General Information
            int pokedex = 007;
            string name = "Totodile";
            string description = "It is small but rough and tough. It won’t hesitate to take a bite out of anything that moves.";
            int gender = (int)Enum.gender.Both;
            double height = 0.6;
            double weight = 9.5;

            //Typing
            int type = (int)Enum.type.Water;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Torrent]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Sheer_Force]);

            //Stats
            int baseHP = 50;
            int baseAttack = 65;
            int baseDefense = 64;
            int baseSpecialAttack = 44;
            int baseSpecialDefense = 48;
            int baseSpeed = 43;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 63;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scratch], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Water_Gun], 6));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Rage], 8));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bite], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scary_Face], 15));
            learnset.Add(new Learnset(moves[(int)Enum.move.Ice_Fang], 20));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flail], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Crunch], 27));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Chip_Away], 29));
            learnset.Add(new Learnset(moves[(int)Enum.move.Slash], 34));
            learnset.Add(new Learnset(moves[(int)Enum.move.Screech], 36));
            learnset.Add(new Learnset(moves[(int)Enum.move.Thrash], 41));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aqua_Tail], 43));
            learnset.Add(new Learnset(moves[(int)Enum.move.Superpower], 48));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hydro_Pump], 50));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Hone_Claws]);
            tmPokemon.Add(moves[(int)Enum.move.Dragon_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Roar]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Hail]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Tomb]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Scald]);
            //tmPokemon.Add(moves[(int)Enum.move.Fling]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Claw]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Slide]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Ancient_Power]);
            tmPokemon.Add(moves[(int)Enum.move.Aqua_Jet]);
            tmPokemon.Add(moves[(int)Enum.move.Block]);
            tmPokemon.Add(moves[(int)Enum.move.Crunch]);
            tmPokemon.Add(moves[(int)Enum.move.Dragon_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Fake_Tears]);
            tmPokemon.Add(moves[(int)Enum.move.Hydro_Pump]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Punch]);
            tmPokemon.Add(moves[(int)Enum.move.Metal_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Mud_Sport]);
            tmPokemon.Add(moves[(int)Enum.move.Thrash]);
            //tmPokemon.Add(moves[(int)Enum.move.Water_Pulse]);
            //tmPokemon.Add(moves[(int)Enum.move.Water_Sport]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);
            tmPokemon.Add(moves[(int)Enum.move.Waterfall]);
            //tmPokemon.Add(moves[(int)Enum.move.Dive]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Croconaw(), 18);
        }
        private PokemonInfo Croconaw()
        {
            //General Information
            int pokedex = 008;
            string name = "Croconaw";
            string description = "Once it bites down, it won’t let go until it loses its fangs. New fangs quickly grow into place.";
            int gender = (int)Enum.gender.Both;
            double height = 1.1;
            double weight = 25;

            //Typing
            int type = (int)Enum.type.Water;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Torrent]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Sheer_Force]);

            //Stats
            int baseHP = 65;
            int baseAttack = 80;
            int baseDefense = 80;
            int baseSpecialAttack = 59;
            int baseSpecialDefense = 63;
            int baseSpeed = 58;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 142;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scratch], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Water_Gun], 6));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Rage], 8));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bite], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scary_Face], 15));
            learnset.Add(new Learnset(moves[(int)Enum.move.Ice_Fang], 21));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flail], 24));
            learnset.Add(new Learnset(moves[(int)Enum.move.Crunch], 30));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Chip_Away], 33));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Slash], 39));
            learnset.Add(new Learnset(moves[(int)Enum.move.Screech], 42));
            learnset.Add(new Learnset(moves[(int)Enum.move.Thrash], 48));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aqua_Tail], 51));
            learnset.Add(new Learnset(moves[(int)Enum.move.Superpower], 57));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hydro_Pump], 60));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Hone_Claws]);
            tmPokemon.Add(moves[(int)Enum.move.Dragon_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Roar]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Hail]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Tomb]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Scald]);
            //tmPokemon.Add(moves[(int)Enum.move.Fling]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Claw]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Slide]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Ancient_Power]);
            tmPokemon.Add(moves[(int)Enum.move.Aqua_Jet]);
            tmPokemon.Add(moves[(int)Enum.move.Block]);
            tmPokemon.Add(moves[(int)Enum.move.Crunch]);
            tmPokemon.Add(moves[(int)Enum.move.Dragon_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Fake_Tears]);
            tmPokemon.Add(moves[(int)Enum.move.Hydro_Pump]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Punch]);
            tmPokemon.Add(moves[(int)Enum.move.Metal_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Mud_Sport]);
            tmPokemon.Add(moves[(int)Enum.move.Thrash]);
            //tmPokemon.Add(moves[(int)Enum.move.Water_Pulse]);
            //tmPokemon.Add(moves[(int)Enum.move.Water_Sport]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);
            tmPokemon.Add(moves[(int)Enum.move.Waterfall]);
            //tmPokemon.Add(moves[(int)Enum.move.Dive]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Feraligatr(), 30);
        }
        private PokemonInfo Feraligatr()
        {
            //General Information
            int pokedex = 009;
            string name = "Feraligatr";
            string description = "It usually moves slowly, but it goes at blinding speed when it attacks and bites prey.";
            int gender = (int)Enum.gender.Both;
            double height = 2.3;
            double weight = 88.8;

            //Typing
            int type = (int)Enum.type.Water;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Torrent]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Sheer_Force]);

            //Stats
            int baseHP = 85;
            int baseAttack = 105;
            int baseDefense = 100;
            int baseSpecialAttack = 79;
            int baseSpecialDefense = 83;
            int baseSpeed = 78;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 239;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scratch], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Water_Gun], 6));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Rage], 8));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bite], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scary_Face], 15));
            learnset.Add(new Learnset(moves[(int)Enum.move.Ice_Fang], 21));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flail], 24));
            learnset.Add(new Learnset(moves[(int)Enum.move.Agility], 30));
            learnset.Add(new Learnset(moves[(int)Enum.move.Crunch], 32));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Chip_Away], 37));
            learnset.Add(new Learnset(moves[(int)Enum.move.Slash], 45));
            learnset.Add(new Learnset(moves[(int)Enum.move.Screech], 50));
            learnset.Add(new Learnset(moves[(int)Enum.move.Thrash], 58));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aqua_Tail], 63));
            learnset.Add(new Learnset(moves[(int)Enum.move.Superpower], 71));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hydro_Pump], 76));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Hone_Claws]);
            tmPokemon.Add(moves[(int)Enum.move.Dragon_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Roar]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Hail]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Earthquake]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Tomb]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Focus_Blast]);
            tmPokemon.Add(moves[(int)Enum.move.Scald]);
            //tmPokemon.Add(moves[(int)Enum.move.Fling]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Claw]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Bulldoze]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Slide]);
            //tmPokemon.Add(moves[(int)Enum.move.Dragon_Tail]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Ancient_Power]);
            tmPokemon.Add(moves[(int)Enum.move.Aqua_Jet]);
            tmPokemon.Add(moves[(int)Enum.move.Block]);
            tmPokemon.Add(moves[(int)Enum.move.Crunch]);
            tmPokemon.Add(moves[(int)Enum.move.Dragon_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Fake_Tears]);
            tmPokemon.Add(moves[(int)Enum.move.Hydro_Pump]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Punch]);
            tmPokemon.Add(moves[(int)Enum.move.Metal_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Mud_Sport]);
            tmPokemon.Add(moves[(int)Enum.move.Thrash]);
            //tmPokemon.Add(moves[(int)Enum.move.Water_Pulse]);
            //tmPokemon.Add(moves[(int)Enum.move.Water_Sport]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);
            tmPokemon.Add(moves[(int)Enum.move.Waterfall]);
            //tmPokemon.Add(moves[(int)Enum.move.Dive]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Rattata()
        {
            //General Information
            int pokedex = 010;
            string name = "Rattata";
            string description = "Living wherever there is food available, it ceaselessly scavenges for edibles the entire day.";
            int gender = (int)Enum.gender.Both;
            double height = 0.3;
            double weight = 3.5;

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
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tail_Whip], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 4));
            learnset.Add(new Learnset(moves[(int)Enum.move.Focus_Energy], 7));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bite], 10));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Pursuit], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hyper_Fang], 16));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sucker_Punch], 19));
            learnset.Add(new Learnset(moves[(int)Enum.move.Crunch], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Assurance], 25));
            learnset.Add(new Learnset(moves[(int)Enum.move.Super_Fang], 28));
            learnset.Add(new Learnset(moves[(int)Enum.move.Double_Edge], 31));
            learnset.Add(new Learnset(moves[(int)Enum.move.Endeavor], 34));
            //=======================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Taunt]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            //tmPokemon.Add(moves[(int)Enum.move.Retaliate]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Pluck]);
            //tmPokemon.Add(moves[(int)Enum.move.U_Turn]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Wild_Charge]);
            tmPokemon.Add(moves[(int)Enum.move.Bite]);
            //tmPokemon.Add(moves[(int)Enum.move.Counter]);
            //tmPokemon.Add(moves[(int)Enum.move.Final_Gambit]);
            tmPokemon.Add(moves[(int)Enum.move.Flame_Wheel]);
            tmPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            //tmPokemon.Add(moves[(int)Enum.move.Last_Resort]);
            //tmPokemon.Add(moves[(int)Enum.move.Revenge]);
            tmPokemon.Add(moves[(int)Enum.move.Screech]);
            //tmPokemon.Add(moves[(int)Enum.move.Uproar]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);                     

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Raticate(), 20);
        }
        private PokemonInfo Raticate()
        {
            //General Information
            int pokedex = 011;
            string name = "Raticate";
            string description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.";
            int gender = (int)Enum.gender.Both;
            double height = 0.7;
            double weight = 18.5;

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
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Swords_Dance], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tail_Whip], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 4));
            learnset.Add(new Learnset(moves[(int)Enum.move.Focus_Energy], 7));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bite], 10));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Pursuit], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hyper_Fang], 16));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sucker_Punch], 19));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scary_Face], 20));
            learnset.Add(new Learnset(moves[(int)Enum.move.Crunch], 24));
            learnset.Add(new Learnset(moves[(int)Enum.move.Assurance], 29));
            learnset.Add(new Learnset(moves[(int)Enum.move.Super_Fang], 34));
            learnset.Add(new Learnset(moves[(int)Enum.move.Double_Edge], 39));
            learnset.Add(new Learnset(moves[(int)Enum.move.Endeavor], 44));
            //========================================================TM
            //tmPokemon.Add(moves[(int)Enum.move.Roar]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Taunt]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            //tmPokemon.Add(moves[(int)Enum.move.Retaliate]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Pluck]);
            //tmPokemon.Add(moves[(int)Enum.move.U_Turn]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Wild_Charge]);
            tmPokemon.Add(moves[(int)Enum.move.Bite]);
            //tmPokemon.Add(moves[(int)Enum.move.Counter]);
            //tmPokemon.Add(moves[(int)Enum.move.Final_Gambit]);
            tmPokemon.Add(moves[(int)Enum.move.Flame_Wheel]);
            tmPokemon.Add(moves[(int)Enum.move.Fury_Swipes]);
            //tmPokemon.Add(moves[(int)Enum.move.Last_Resort]);
            //tmPokemon.Add(moves[(int)Enum.move.Revenge]);
            tmPokemon.Add(moves[(int)Enum.move.Screech]);
            //tmPokemon.Add(moves[(int)Enum.move.Uproar]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);
         
            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Sentret()
        {
            //General Information
            int pokedex = 012;
            string name = "Sentret";
            string description = "It stands on its tail so it can see a long way. If it spots an enemy, it cries loudly to warn its kind.";
            int gender = (int)Enum.gender.Both;
            double height = 0.8;
            double weight = 6;

            //Typing
            int type = (int)Enum.type.Normal;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Run_Away]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Keen_Eye]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Frisk]);

            //Stats
            int baseHP = 35;
            int baseAttack = 46;
            int baseDefense = 34;
            int baseSpecialAttack = 35;
            int baseSpecialDefense = 45;
            int baseSpeed = 20;

            //Battle
            int catchrate = 255;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 43;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Charm], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scratch], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Defense_Curl], 4));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 7));
            learnset.Add(new Learnset(moves[(int)Enum.move.Fury_Swipes], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Swift], 16));
            learnset.Add(new Learnset(moves[(int)Enum.move.Slam], 19));
            learnset.Add(new Learnset(moves[(int)Enum.move.Rest], 25));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sucker_Punch], 28));
            learnset.Add(new Learnset(moves[(int)Enum.move.Amnesia], 31));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hyper_Voice], 36));
            //=======================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Hone_Claws]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Flamethrower]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Focus_Blast]);
            tmPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Retaliate]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.U_Turn]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            //tmPokemon.Add(moves[(int)Enum.move.Assist]);
            tmPokemon.Add(moves[(int)Enum.move.Charm]);
            //tmPokemon.Add(moves[(int)Enum.move.Covet]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Edge]);
            tmPokemon.Add(moves[(int)Enum.move.Focus_Energy]);
            tmPokemon.Add(moves[(int)Enum.move.Iron_Tail]);
            //tmPokemon.Add(moves[(int)Enum.move.Last_Resort]);
            //tmPokemon.Add(moves[(int)Enum.move.Pursuit]);
            //tmPokemon.Add(moves[(int)Enum.move.Reversal]);
            tmPokemon.Add(moves[(int)Enum.move.Slash]);
            //tmPokemon.Add(moves[(int)Enum.move.Trick]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);           

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Furret(), 15);
        }
        private PokemonInfo Furret()
        {
            //General Information
            int pokedex = 013;
            string name = "Furret";
            string description = "Furret is a POKéMON that loves walking around all kind of places.";
            int gender = (int)Enum.gender.Both;
            double height = 1.8;
            double weight = 32.5;

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
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Agility], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Coil], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Defense_Curl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Charm], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scratch], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Fury_Swipes], 13));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Assist], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Swift], 21));
            learnset.Add(new Learnset(moves[(int)Enum.move.Slam], 28));
            learnset.Add(new Learnset(moves[(int)Enum.move.Rest], 32));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sucker_Punch], 36));
            learnset.Add(new Learnset(moves[(int)Enum.move.Amnesia], 42));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hyper_Voice], 46));
            //=======================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Hone_Claws]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Flamethrower]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Focus_Blast]);
            tmPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Claw]);
            //tmPokemon.Add(moves[(int)Enum.move.Retaliate]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.U_Turn]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            //tmPokemon.Add(moves[(int)Enum.move.Assist]);
            tmPokemon.Add(moves[(int)Enum.move.Charm]);
            //tmPokemon.Add(moves[(int)Enum.move.Covet]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Edge]);
            tmPokemon.Add(moves[(int)Enum.move.Focus_Energy]);
            tmPokemon.Add(moves[(int)Enum.move.Iron_Tail]);
            //tmPokemon.Add(moves[(int)Enum.move.Last_Resort]);
            //tmPokemon.Add(moves[(int)Enum.move.Pursuit]);
            //tmPokemon.Add(moves[(int)Enum.move.Reversal]);
            tmPokemon.Add(moves[(int)Enum.move.Slash]);
            //tmPokemon.Add(moves[(int)Enum.move.Trick]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        //Zigzagoon
        //Linoone
        //Bidoof
        //Bibarel
        //Pidgey
        //Pidgeotto
        //Pidgeot
        private PokemonInfo Hoothoot()
        {
            //General Information
            int pokedex = 022;
            string name = "Hoothoot";
            string description = "It switches its standing foot so quickly, it can’t be seen. It cries at the same time every day.";
            int gender = (int)Enum.gender.Both;
            double height = 0.7;
            double weight = 21.2;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Normal);
            types.Add((int)Enum.type.Fly);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Insomnia]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Keen_Eye]);

            //Stats
            int baseHP = 60;
            int baseAttack = 30;
            int baseDefense = 30;
            int baseSpecialAttack = 36;
            int baseSpecialDefense = 56;
            int baseSpeed = 50;

            //Battle
            int catchrate = 255;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 52;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            //learnset.Add(new Learnset(moves[(int)Enum.move.Foresight], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hypnosis], 5));
            learnset.Add(new Learnset(moves[(int)Enum.move.Peck], 9));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Uproar], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Reflect], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Confusion], 21));
            learnset.Add(new Learnset(moves[(int)Enum.move.Take_Down], 25));
            learnset.Add(new Learnset(moves[(int)Enum.move.Air_Slash], 29));
            learnset.Add(new Learnset(moves[(int)Enum.move.Zen_Headbutt], 33));
            learnset.Add(new Learnset(moves[(int)Enum.move.Extrasensory], 41));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Psycho_Shift], 49));
            learnset.Add(new Learnset(moves[(int)Enum.move.Roost], 53));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Dream_Eater], 57));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Psychic]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Reflect]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Psych_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            //tmPokemon.Add(moves[(int)Enum.move.Dream_Eater]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Pluck]);;
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Agility]);
            tmPokemon.Add(moves[(int)Enum.move.Defog]);
            tmPokemon.Add(moves[(int)Enum.move.Feather_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Feint_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Mirror_Move]);
            //tmPokemon.Add(moves[(int)Enum.move.Night_Shade]);
            //tmPokemon.Add(moves[(int)Enum.move.Sky_Attack]);
            tmPokemon.Add(moves[(int)Enum.move.Supersonic]);
            //tmPokemon.Add(moves[(int)Enum.move.Whirlwind]);
            tmPokemon.Add(moves[(int)Enum.move.Wing_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Fly]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Noctowl(), 20);
        }
        private PokemonInfo Noctowl()
        {
            //General Information
            int pokedex = 022;
            string name = "Noctowl";
            string description = "If it flips its head upside down, it’s a sign that it is engaged in very complex thinking.";
            int gender = (int)Enum.gender.Both;
            double height = 1.6;
            double weight = 40.8;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Normal);
            types.Add((int)Enum.type.Fly);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Insomnia]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Keen_Eye]);

            //Stats
            int baseHP = 100;
            int baseAttack = 50;
            int baseDefense = 50;
            int baseSpecialAttack = 86;
            int baseSpecialDefense = 96;
            int baseSpeed = 70;

            //Battle
            int catchrate = 90;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 158;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            //learnset.Add(new Learnset(moves[(int)Enum.move.Foresight], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Sky_Attack], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hypnosis], 5));
            learnset.Add(new Learnset(moves[(int)Enum.move.Peck], 9));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Uproar], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Reflect], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Confusion], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Take_Down], 32));
            learnset.Add(new Learnset(moves[(int)Enum.move.Air_Slash], 37));
            learnset.Add(new Learnset(moves[(int)Enum.move.Zen_Headbutt], 42));
            learnset.Add(new Learnset(moves[(int)Enum.move.Extrasensory], 47));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Psycho_Shift], 52));
            learnset.Add(new Learnset(moves[(int)Enum.move.Roost], 57));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Dream_Eater], 62));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Psychic]);
            tmPokemon.Add(moves[(int)Enum.move.Shadow_Ball]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Reflect]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Psych_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            //tmPokemon.Add(moves[(int)Enum.move.Dream_Eater]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Pluck]);;
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Agility]);
            tmPokemon.Add(moves[(int)Enum.move.Defog]);
            tmPokemon.Add(moves[(int)Enum.move.Feather_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Feint_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Mirror_Move]);
            //tmPokemon.Add(moves[(int)Enum.move.Night_Shade]);
            //tmPokemon.Add(moves[(int)Enum.move.Sky_Attack]);
            tmPokemon.Add(moves[(int)Enum.move.Supersonic]);
            //tmPokemon.Add(moves[(int)Enum.move.Whirlwind]);
            tmPokemon.Add(moves[(int)Enum.move.Wing_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Fly]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Taillow()
        {
            //General Information
            int pokedex = 023;
            string name = "Taillow";
            string description = "Taillow courageously stands its ground against foes, however strong they may be. This gutsy Pokémon will remain defiant even after a loss. On the other hand, it cries loudly if it becomes hungry.";
            int gender = (int)Enum.gender.Both;
            double height = 0.3;
            double weight = 2.3;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Normal);
            types.Add((int)Enum.type.Fly);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Guts]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Scrappy]);

            //Stats
            int baseHP = 40;
            int baseAttack = 55;
            int baseDefense = 30;
            int baseSpecialAttack = 30;
            int baseSpecialDefense = 30;
            int baseSpeed = 85;

            //Battle
            int catchrate = 200;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 54;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Peck], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Focus_Energy], 4));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 8));
            learnset.Add(new Learnset(moves[(int)Enum.move.Wing_Attack], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Double_Team], 19));
            learnset.Add(new Learnset(moves[(int)Enum.move.Endeavor], 26));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aerial_Ace], 34));
            learnset.Add(new Learnset(moves[(int)Enum.move.Agility], 43));
            learnset.Add(new Learnset(moves[(int)Enum.move.Air_Slash], 53));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Pluck]);
            //tmPokemon.Add(moves[(int)Enum.move.U_turn]);
            tmPokemon.Add(moves[(int)Enum.move.Brave_Bird]);
            tmPokemon.Add(moves[(int)Enum.move.Defog]);
            //tmPokemon.Add(moves[(int)Enum.move.Mirror_Move]);
            //tmPokemon.Add(moves[(int)Enum.move.Rage]);
            //tmPokemon.Add(moves[(int)Enum.move.Refresh]);
            tmPokemon.Add(moves[(int)Enum.move.Roost]);
            //tmPokemon.Add(moves[(int)Enum.move.Sky_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Steel_Wing]);
            tmPokemon.Add(moves[(int)Enum.move.Supersonic]);
            //tmPokemon.Add(moves[(int)Enum.move.Whirlwind]);
            //tmPokemon.Add(moves[(int)Enum.move.Fly]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Swellow(), 22);
        }
        private PokemonInfo Swellow()
        {
            //General Information
            int pokedex = 024;
            string name = "Swellow";
            string description = "It circles the sky in search of prey. When it spots one, it dives steeply to catch the prey.";
            int gender = (int)Enum.gender.Both;
            double height = 0.7;
            double weight = 19.8;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Normal);
            types.Add((int)Enum.type.Fly);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Guts]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Scrappy]);

            //Stats
            int baseHP = 60;
            int baseAttack = 85;
            int baseDefense = 60;
            int baseSpecialAttack = 75;
            int baseSpecialDefense = 50;
            int baseSpeed = 125;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Medium_Slow;
            int experienceYield = 159;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Peck], 1));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Pluck], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Focus_Energy], 4));
            learnset.Add(new Learnset(moves[(int)Enum.move.Wing_Attack], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Double_Team], 19));
            learnset.Add(new Learnset(moves[(int)Enum.move.Endeavor], 28));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aerial_Ace], 38));
            learnset.Add(new Learnset(moves[(int)Enum.move.Agility], 49));
            learnset.Add(new Learnset(moves[(int)Enum.move.Air_Slash], 61));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Work_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Pluck]);;
            //tmPokemon.Add(moves[(int)Enum.move.U_turn]);
            tmPokemon.Add(moves[(int)Enum.move.Brave_Bird]);
            tmPokemon.Add(moves[(int)Enum.move.Defog]);
            //tmPokemon.Add(moves[(int)Enum.move.Mirror_Move]);
            //tmPokemon.Add(moves[(int)Enum.move.Rage]);
            //tmPokemon.Add(moves[(int)Enum.move.Refresh]);
            tmPokemon.Add(moves[(int)Enum.move.Roost]);
            //tmPokemon.Add(moves[(int)Enum.move.Sky_Attack]);
            //tmPokemon.Add(moves[(int)Enum.move.Steel_Wing]);
            tmPokemon.Add(moves[(int)Enum.move.Supersonic]);
            //tmPokemon.Add(moves[(int)Enum.move.Whirlwind]);
            //tmPokemon.Add(moves[(int)Enum.move.Fly]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        //Starly
        //Staravia
        //Staraptor
        //Caterpie,
        //Metapod
        //Butterfree
        //Wurmple
        //Silcoon
        //Beautifly
        //Oddish
        //Gloom
        //Vileplume
        //Bellossom
        private PokemonInfo Paras()
        {
            //General Information
            int pokedex = 038;
            string name = "Paras";
            string description = "Mushrooms named tochukaso grow on its back. They grow along with the host Paras.";
            int gender = (int)Enum.gender.Both;
            double height = 0.3;
            double weight = 5.4;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Bug);
            types.Add((int)Enum.type.Grass);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Effect_Spore]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Dry_Skin]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Damp]);

            //Stats
            int baseHP = 35;
            int baseAttack = 70;
            int baseDefense = 55;
            int baseSpecialAttack = 45;
            int baseSpecialDefense = 55;
            int baseSpeed = 25;

            //Battle
            int catchrate = 190;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 57;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Scratch], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Stun_Spore], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Poison_Powder], 6));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Leech_Life], 11));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Fury_Cutter], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Spore], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Slash], 27));
            learnset.Add(new Learnset(moves[(int)Enum.move.Growth], 33));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Giga_Drain], 38));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aromatherapy], 43));
            learnset.Add(new Learnset(moves[(int)Enum.move.X_Scissor], 49));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Hone_Claws]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            //tmPokemon.Add(moves[(int)Enum.move.Venoshock]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Sludge_Bomb]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Energy_Ball]);
            //tmPokemon.Add(moves[(int)Enum.move.False_Swipe]);
            tmPokemon.Add(moves[(int)Enum.move.Flash]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Struggle_Bug]);
            tmPokemon.Add(moves[(int)Enum.move.X_Scissor]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);

            tmPokemon.Add(moves[(int)Enum.move.Agility]);
            //tmPokemon.Add(moves[(int)Enum.move.Bug_Bite]);
            //tmPokemon.Add(moves[(int)Enum.move.Counter]);
            tmPokemon.Add(moves[(int)Enum.move.Cross_Poison]);
            tmPokemon.Add(moves[(int)Enum.move.Endure]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Leech_Seed]);
            tmPokemon.Add(moves[(int)Enum.move.Metal_Claw]);
            tmPokemon.Add(moves[(int)Enum.move.Psybeam]);
            //tmPokemon.Add(moves[(int)Enum.move.Pursuit]);
            tmPokemon.Add(moves[(int)Enum.move.Screech]);
            tmPokemon.Add(moves[(int)Enum.move.Sweet_Scent]);

            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Parasect()
        {
            //General Information
            int pokedex = 039;
            string name = "Parasect";
            string description = "It is controlled by a mushroom grown larger than the bug body. It is said to prefer damp places.";
            int gender = (int)Enum.gender.Both;
            double height = 1;
            double weight = 29.5;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Bug);
            types.Add((int)Enum.type.Grass);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Effect_Spore]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Dry_Skin]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Damp]);

            //Stats
            int baseHP = 60;
            int baseAttack = 95;
            int baseDefense = 80;
            int baseSpecialAttack = 60;
            int baseSpecialDefense = 80;
            int baseSpeed = 30;

            //Battle
            int catchrate = 75;
            int experience = (int)Enum.experience.Medium_Fast;
            int experienceYield = 142;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Cross_Poison], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Scratch], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Stun_Spore], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Poison_Powder], 6));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Leech_Life], 11));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Fury_Cutter], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Spore], 22));
            learnset.Add(new Learnset(moves[(int)Enum.move.Slash], 29));
            learnset.Add(new Learnset(moves[(int)Enum.move.Growth], 37));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Giga_Drain], 44));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aromatherapy], 51));
            learnset.Add(new Learnset(moves[(int)Enum.move.X_Scissor], 59));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Hone_Claws]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            //tmPokemon.Add(moves[(int)Enum.move.Venoshock]);
            tmPokemon.Add(moves[(int)Enum.move.Sunny_Day]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            //tmPokemon.Add(moves[(int)Enum.move.Solar_Beam]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Brick_Break]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Sludge_Bomb]);
            tmPokemon.Add(moves[(int)Enum.move.Aerial_Ace]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Thief]);
            tmPokemon.Add(moves[(int)Enum.move.Energy_Ball]);
            //tmPokemon.Add(moves[(int)Enum.move.False_Swipe]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Flash]);
            tmPokemon.Add(moves[(int)Enum.move.Swords_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Struggle_Bug]);
            tmPokemon.Add(moves[(int)Enum.move.X_Scissor]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);

            tmPokemon.Add(moves[(int)Enum.move.Agility]);
            //tmPokemon.Add(moves[(int)Enum.move.Bug_Bite]);
            //tmPokemon.Add(moves[(int)Enum.move.Counter]);
            tmPokemon.Add(moves[(int)Enum.move.Cross_Poison]);
            tmPokemon.Add(moves[(int)Enum.move.Endure]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Leech_Seed]);
            tmPokemon.Add(moves[(int)Enum.move.Metal_Claw]);
            tmPokemon.Add(moves[(int)Enum.move.Psybeam]);
            //tmPokemon.Add(moves[(int)Enum.move.Pursuit]);
            tmPokemon.Add(moves[(int)Enum.move.Screech]);
            tmPokemon.Add(moves[(int)Enum.move.Sweet_Scent]);

            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        //Spinarak
        //Ariados
        //Scyther
        //Scizor
        //Pinsir
        //Surskit
        //Masquerain
        //Horsea
        //Seadra
        //Kingdra
        private PokemonInfo Finneon()
        {
            //General Information
            int pokedex = 050;
            string name = "Finneon";
            string description = "After long exposure to sunlight, the patterns on its tail fins shine vividly when darkness arrives.";
            int gender = (int)Enum.gender.Both;
            double height = 0.4;
            double weight = 7;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Water);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Swift_Swim]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Storm_Drain]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Water_Veil]);

            //Stats
            int baseHP = 49;
            int baseAttack = 49;
            int baseDefense = 56;
            int baseSpecialAttack = 49;
            int baseSpecialDefense = 61;
            int baseSpeed = 66;

            //Battle
            int catchrate = 190;
            int experience = (int)Enum.experience.Erratic;
            int experienceYield = 66;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Pound], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Water_Gun], 6));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Attract], 10));
            learnset.Add(new Learnset(moves[(int)Enum.move.Rain_Dance], 13));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Gust], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Water_Pulse], 22));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Captivate], 26));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Safeguard], 29));
            //learnset.Add(new Learnsetmoves[(int)Enum.move.Aqua_Ring], 33));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Whirlpool], 38));
            //learnset.Add(new Learnset(moves[(int)Enum.move.U_Turn], 42));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bounce], 45));
            learnset.Add(new Learnset(moves[(int)Enum.move.Silver_Wing], 49));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Soak], 54));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Hail]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Safeguard]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Scald]);
            //tmPokemon.Add(moves[(int)Enum.move.Payback]);
            tmPokemon.Add(moves[(int)Enum.move.Psych_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.U_Turn]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Agility]);
            tmPokemon.Add(moves[(int)Enum.move.Aqua_Tail]);
            tmPokemon.Add(moves[(int)Enum.move.Aurora_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Brine]);
            tmPokemon.Add(moves[(int)Enum.move.Charm]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Psybeam]);
            tmPokemon.Add(moves[(int)Enum.move.Signal_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Splash]);
            tmPokemon.Add(moves[(int)Enum.move.Sweet_Kiss]);
            tmPokemon.Add(moves[(int)Enum.move.Tickle]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);
            tmPokemon.Add(moves[(int)Enum.move.Waterfall]);
            //tmPokemon.Add(moves[(int)Enum.move.Dive]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Lumineon()
        {
            //General Information
            int pokedex = 051;
            string name = "Lumineon";
            string description = "It crawls along the seafloor using its long front fins like legs. It competes for food with Lanturn.";
            int gender = (int)Enum.gender.Both;
            double height = 1.2;
            double weight = 24;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Water);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Swift_Swim]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Storm_Drain]);
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Water_Veil]);

            //Stats
            int baseHP = 69;
            int baseAttack = 69;
            int baseDefense = 76;
            int baseSpecialAttack = 69;
            int baseSpecialDefense = 86;
            int baseSpeed = 91;

            //Battle
            int catchrate = 75;
            int experience = (int)Enum.experience.Erratic;
            int experienceYield = 161;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Attract], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Pound], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Water_Gun], 6));
            learnset.Add(new Learnset(moves[(int)Enum.move.Rain_Dance], 13));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Gust], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Water_Pulse], 22));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Captivate], 26));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Safeguard], 29));
            //learnset.Add(new Learnsetmoves[(int)Enum.move.Aqua_Ring], 35));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Whirlpool], 42));
            //learnset.Add(new Learnset(moves[(int)Enum.move.U_Turn], 48));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bounce], 53));
            learnset.Add(new Learnset(moves[(int)Enum.move.Silver_Wing], 59));
            //learnset.Add(new Learnset(moves[(int)Enum.move.Soak], 66));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Hail]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            //tmPokemon.Add(moves[(int)Enum.move.Safeguard]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Scald]);
            //tmPokemon.Add(moves[(int)Enum.move.Payback]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Flash]);
            tmPokemon.Add(moves[(int)Enum.move.Psych_Up]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.U_Turn]);
            tmPokemon.Add(moves[(int)Enum.move.Agility]);
            tmPokemon.Add(moves[(int)Enum.move.Aqua_Tail]);
            tmPokemon.Add(moves[(int)Enum.move.Aurora_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Brine]);
            tmPokemon.Add(moves[(int)Enum.move.Charm]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Psybeam]);
            tmPokemon.Add(moves[(int)Enum.move.Signal_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Splash]);
            tmPokemon.Add(moves[(int)Enum.move.Sweet_Kiss]);
            tmPokemon.Add(moves[(int)Enum.move.Tickle]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);
            tmPokemon.Add(moves[(int)Enum.move.Waterfall]);
            //tmPokemon.Add(moves[(int)Enum.move.Dive]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        private PokemonInfo Magikarp()
        {
            //General Information
            int pokedex = 052;
            string name = "Magikarp";
            string description = "It is said to be the world’s weakest Pokémon. No one knows why it has managed to survive.";
            int gender = (int)Enum.gender.Both;
            double height = 0.9;
            double weight = 10;

            //Typing
            int type = (int)Enum.type.Water;

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Swift_Swim]);

            //Stats
            int baseHP = 20;
            int baseAttack = 10;
            int baseDefense = 55;
            int baseSpecialAttack = 15;
            int baseSpecialDefense = 20;
            int baseSpeed = 80;

            //Battle
            int catchrate = 255;
            int experience = (int)Enum.experience.Slow;
            int experienceYield = 40;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Splash], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Tackle], 15));
            learnset.Add(new Learnset(moves[(int)Enum.move.Flail], 30));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Bounce]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon, Gyarados(), 20);
        }
        private PokemonInfo Gyarados()
        {
            //General Information
            int pokedex = 053;
            string name = "Gyarados";
            string description = "Once it appears, its rage never settles until it has razed the fields and mountains around it.";
            int gender = (int)Enum.gender.Both;
            double height = 6.5;
            double weight = 235;

            //Typing
            List<int> types = new List<int>();
            types.Add((int)Enum.type.Water);
            types.Add((int)Enum.type.Fly);

            //Abilities
            List<Ability> abilitiesPokemon = new List<Ability>();
            abilitiesPokemon.Add(abilities[(int)Enum.ability.Intimidate]);

            //Stats
            int baseHP = 95;
            int baseAttack = 125;
            int baseDefense = 79;
            int baseSpecialAttack = 60;
            int baseSpecialDefense = 100;
            int baseSpeed = 81;

            //Battle
            int catchrate = 45;
            int experience = (int)Enum.experience.Slow;
            int experienceYield = 189;

            //Moves
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Thrash], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Bite], 20));
            learnset.Add(new Learnset(moves[(int)Enum.move.Dragon_Rage], 23));
            learnset.Add(new Learnset(moves[(int)Enum.move.Leer], 26));
            learnset.Add(new Learnset(moves[(int)Enum.move.Twister], 29));
            learnset.Add(new Learnset(moves[(int)Enum.move.Ice_Fang], 32));
            learnset.Add(new Learnset(moves[(int)Enum.move.Aqua_Tail], 35));
            learnset.Add(new Learnset(moves[(int)Enum.move.Rain_Dance], 38));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hydro_Pump], 41));
            learnset.Add(new Learnset(moves[(int)Enum.move.Dragon_Dance], 44));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hyper_Beam], 47));
            //========================================================TM
            //tmPokemon.Add(moves[(int)Enum.move.Roar]);
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            tmPokemon.Add(moves[(int)Enum.move.Hail]);
            tmPokemon.Add(moves[(int)Enum.move.Taunt]);
            tmPokemon.Add(moves[(int)Enum.move.Ice_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Blizzard]);
            tmPokemon.Add(moves[(int)Enum.move.Hyper_Beam]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder]);
            //tmPokemon.Add(moves[(int)Enum.move.Earthquake]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Flamethrower]);
            tmPokemon.Add(moves[(int)Enum.move.Sandstorm]);
            tmPokemon.Add(moves[(int)Enum.move.Fire_Blast]);
            tmPokemon.Add(moves[(int)Enum.move.Torment]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            tmPokemon.Add(moves[(int)Enum.move.Scald]);
            //tmPokemon.Add(moves[(int)Enum.move.Incinerate]);
            //tmPokemon.Add(moves[(int)Enum.move.Payback]);
            tmPokemon.Add(moves[(int)Enum.move.Giga_Impact]);
            tmPokemon.Add(moves[(int)Enum.move.Stone_Edge]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            tmPokemon.Add(moves[(int)Enum.move.Bulldoze]);
            //tmPokemon.Add(moves[(int)Enum.move.Dragon_Tail]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            tmPokemon.Add(moves[(int)Enum.move.Rock_Smash]);
            //tmPokemon.Add(moves[(int)Enum.move.Surf]);
            tmPokemon.Add(moves[(int)Enum.move.Waterfall]);
            //tmPokemon.Add(moves[(int)Enum.move.Dive]);
            tmPokemon.Add(moves[(int)Enum.move.Strength]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, types, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
        //Nidoran♀
        //Nidorina
        //Nidoqueen
        //Nidoran♂
        //Nidorino
        //Nidoking
        //Diglett
        //Dugtrio
        //Aron
        //Lairon
        //Aggron
        //Kabuto
        //Kabutops
        //Shieldon
        //Bastiodon
        //Dunsparce
        //Onix
        //Phanpy
        //Donphan
        //Sandshrew
        //Sandslash
        //Farfetch'd
        //Sudowoodo
        //Swablu
        //Altaria
        private PokemonInfo Pachirisu()
        {
            //General Information
            int pokedex = 420;
            string name = "Pachirisu";
            string description = "It’s one of the kinds of Pokémon with electric cheek pouches. It shoots charges from its tail.";
            int gender = (int)Enum.gender.Both;
            double height = 0.4;
            double weight = 3.9;

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
            List<Learnset> learnset = new List<Learnset>();
            List<Move> tmPokemon = new List<Move>();
            //========================================================Leveling
            learnset.Add(new Learnset(moves[(int)Enum.move.Growl], 1));
            learnset.Add(new Learnset(moves[(int)Enum.move.Quick_Attack], 5));
            learnset.Add(new Learnset(moves[(int)Enum.move.Charm], 9));
            learnset.Add(new Learnset(moves[(int)Enum.move.Spark], 13));
            learnset.Add(new Learnset(moves[(int)Enum.move.Endure], 17));
            learnset.Add(new Learnset(moves[(int)Enum.move.Nuzzle], 19));
            learnset.Add(new Learnset(moves[(int)Enum.move.Swift], 21));
            learnset.Add(new Learnset(moves[(int)Enum.move.Electro_Ball], 25));
            learnset.Add(new Learnset(moves[(int)Enum.move.Sweet_Kiss], 29));
            learnset.Add(new Learnset(moves[(int)Enum.move.Thunder_Wave], 33));
            learnset.Add(new Learnset(moves[(int)Enum.move.Super_Fang], 37));
            learnset.Add(new Learnset(moves[(int)Enum.move.Discharge], 41));
            learnset.Add(new Learnset(moves[(int)Enum.move.Iron_Tail], 45));
            learnset.Add(new Learnset(moves[(int)Enum.move.Hyper_Fang], 49));
            //========================================================TM
            tmPokemon.Add(moves[(int)Enum.move.Toxic]);
            //tmPokemon.Add(moves[(int)Enum.move.Light_Screen]);
            tmPokemon.Add(moves[(int)Enum.move.Protect]);
            tmPokemon.Add(moves[(int)Enum.move.Rain_Dance]);
            tmPokemon.Add(moves[(int)Enum.move.Thunderbolt]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder]);
            //tmPokemon.Add(moves[(int)Enum.move.Dig]);
            tmPokemon.Add(moves[(int)Enum.move.Double_Team]);
            tmPokemon.Add(moves[(int)Enum.move.Facade]);
            tmPokemon.Add(moves[(int)Enum.move.Rest]);
            tmPokemon.Add(moves[(int)Enum.move.Attract]);
            //tmPokemon.Add(moves[(int)Enum.move.Fling]);
            tmPokemon.Add(moves[(int)Enum.move.Charge_Beam]);
            //tmPokemon.Add(moves[(int)Enum.move.Volt_Switch]);
            tmPokemon.Add(moves[(int)Enum.move.Thunder_Wave]);
            tmPokemon.Add(moves[(int)Enum.move.Grass_Knot]);
            tmPokemon.Add(moves[(int)Enum.move.Swagger]);
            //tmPokemon.Add(moves[(int)Enum.move.U_turn]);
            //tmPokemon.Add(moves[(int)Enum.move.Substitute]);
            tmPokemon.Add(moves[(int)Enum.move.Bite]);
            //tmPokemon.Add(moves[(int)Enum.move.Charge]);
            tmPokemon.Add(moves[(int)Enum.move.Defense_Curl]);
            tmPokemon.Add(moves[(int)Enum.move.Fake_Tears]);
            tmPokemon.Add(moves[(int)Enum.move.Flail]);
            tmPokemon.Add(moves[(int)Enum.move.Flatter]);
            tmPokemon.Add(moves[(int)Enum.move.Iron_Tail]);
            //tmPokemon.Add(moves[(int)Enum.move.Rollout]);
            tmPokemon.Add(moves[(int)Enum.move.Tail_Whip]);
            tmPokemon.Add(moves[(int)Enum.move.Cut]);

            return new PokemonInfo(pokedex, name, description, gender, height, weight, type, abilitiesPokemon, catchrate, experience, experienceYield, baseHP, baseAttack, baseDefense, baseSpecialAttack, baseSpecialDefense, baseSpeed, learnset, tmPokemon);
        }
    }
}

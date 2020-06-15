using Pokemon_Beep.Battle;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep.Factory
{
    class PokemonFactory
    {
        public List<PocketMonster> GetPokemons()
        {
            List<PocketMonster> pokemons = new List<PocketMonster>();
            AbilityFactory abilityFactory = new AbilityFactory();
            List<Ability> abilities = abilityFactory.GetAbilities();
            //Chikorita
            List<Ability> abilitiesChikorita = new List<Ability>();
            List<Learnset> learnsetChikorita = new List<Learnset>();
            abilitiesChikorita.Add(abilities[(int) Enum.ability.Overgrow]);
            abilitiesChikorita.Add(abilities[(int)Enum.ability.Leaf_Guard]);
            pokemons.Add(new PocketMonster(001, "Chikorita", "A sweet aroma gently wafts from the leaf on its head. It is docile and loves to soak up the sun's rays.", (int)Enum.gender.both, 0.9, 6.4, (int)Enum.colour.Green, (int)Enum.shape.Flower, (int)Enum.type.Grass, abilitiesChikorita, 45, (int)Enum.experience.Medium_Slow, 64, 45, 49, 65, 49, 65, 45, learnsetChikorita));
            return pokemons;
        }
    }
}

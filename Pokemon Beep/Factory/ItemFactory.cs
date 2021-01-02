using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pokemon_Beep.Combat;
using Pokemon_Beep.Other;
using Pokemon_Beep.Player;

namespace Pokemon_Beep.Factory
{
    class ItemFactory
    {
        delegate void effect(Protagonist player);
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>();

            //Categorie : Healing

            //Potions --

            void Potion(Protagonist player)
            { heal(player, 30); }
            effect PotionEffect = new effect(Potion);
            items.Add(new Item("Potion", "Instruction: Use the bottle to spray on the wounded Pokémon. It can restores up to 30 HP.", (int)Enum.categorie.Healing, PotionEffect, 300));
            
            void SuperPotion(Protagonist player)
            { heal(player, 60); }
            effect SuperPotionEffect = new effect(SuperPotion);
            items.Add(new Item("Super Potion", "Instruction: Use the bottle to spray on the wounded Pokémon. It can restores up to 60 HP.", (int)Enum.categorie.Healing, SuperPotionEffect, 700));
            
            void HyperPotion(Protagonist player)
            { heal(player, 120); }
            effect HyperPotionEffect = new effect(HyperPotion);
            items.Add(new Item("Hyper Potion", "Instruction: Use the bottle to spray on the wounded Pokémon. It can restores up to 120 HP.", (int)Enum.categorie.Healing, HyperPotionEffect, 1200));

            //Status --

            void Antidote(Protagonist player)
            { cure(player, (int)Enum.status.Poisoned); }
            effect AntidoteEffect = new effect(Antidote);
            items.Add(new Item("Antidote", "Instruction: Use the bottle to spray on the affected area. It can cure POISON.", (int)Enum.categorie.Healing, AntidoteEffect, 250));
           
            void ParalyzeHeal(Protagonist player)
            { cure(player, (int)Enum.status.Paralyzed); }
            effect ParalyzeHealEffect = new effect(ParalyzeHeal);
            items.Add(new Item("Paralyze Heal", "Instruction: Use the bottle to spray on the affected area. It can cure PARALYSIS.", (int)Enum.categorie.Healing, ParalyzeHealEffect, 250));           
            
            void BurnHeal(Protagonist player)
            { cure(player, (int)Enum.status.Burned); }
            effect BurnHealEffect = new effect(BurnHeal);
            items.Add(new Item("Burn Heal", "Instruction: Use the bottle to spray on the affected area. It can cure BURN.", (int)Enum.categorie.Healing, BurnHealEffect, 250));

            void Awakening(Protagonist player)
            { cure(player, (int)Enum.status.Sleep); }
            effect AwakeningEffect = new effect(Awakening);
            items.Add(new Item("Awakening", "Instruction: Use the bottle to spray on the affected area. It can cure SLEEP.", (int)Enum.categorie.Healing, AwakeningEffect, 250));

            void IceHeal(Protagonist player)
            { cure(player, (int)Enum.status.Frozen); }
            effect IceHealEffect = new effect(IceHeal);
            items.Add(new Item("Ice Heal", "Instruction: Use the bottle to spray on the affected area. It can cure FROZE.", (int)Enum.categorie.Healing, IceHealEffect, 250));

            void FullHeal(Protagonist player)
            { cure(player, 10); }
            effect FullHealEffect = new effect(FullHeal);
            items.Add(new Item("Full Heal", "Instruction: Use the bottle to spray on the affected area. It can cure ANY status.", (int)Enum.categorie.Healing, FullHealEffect, 600));

            //Categorie : Berries

            //HP --

            //Oran Berry
            void OranBerry(Protagonist player)
            { heal(player, 10); }
            effect OranBerryEffect = new effect(OranBerry);
            items.Add(new Item("Oran Berry", "A tasteful berry that can be held by a Pokémon and restores up to 10 HP.", (int)Enum.categorie.Berries, OranBerryEffect, 150));

            //Status --

            //Chesto Berry
            void ChestoBerry(Protagonist player)
            { cure(player, (int)Enum.status.Sleep); }
            effect ChestoBerryEffect = new effect(ChestoBerry);
            items.Add(new Item("Chesto Berry", "A dry berry that can held by a Pokémon and cure SLEEP status.", (int)Enum.categorie.Berries, ChestoBerryEffect, 450));
            //Cheri Berry
            void CheriBerry(Protagonist player)
            { cure(player, (int)Enum.status.Paralyzed); }
            effect CheriBerryEffect = new effect(CheriBerry);
            items.Add(new Item("Cheri Berry", "A spicy berry that can held by a Pokémon and cure PARALYSIS status.", (int)Enum.categorie.Berries, CheriBerryEffect, 450));
            //Pecha Berry
            void PechaBerry(Protagonist player)
            { cure(player, (int)Enum.status.Poisoned); }
            effect PechaBerryEffect = new effect(PechaBerry);
            items.Add(new Item("Pecha Berry", "A spicy berry that can held by a Pokémon and cure POISON status.", (int)Enum.categorie.Berries, PechaBerryEffect, 450));
            //Rawst Berry
            void RawstBerry(Protagonist player)
            { cure(player, (int)Enum.status.Burned); }
            effect RawstBerryEffect = new effect(RawstBerry);
            items.Add(new Item("Rawst Berry", "A bitter berry that can held by a Pokémon and cure BURN status.", (int)Enum.categorie.Berries, RawstBerryEffect, 450));
            //Aspear Berry
            void AspearBerry(Protagonist player)
            { cure(player, (int)Enum.status.Frozen); }
            effect AspearBerryEffect = new effect(AspearBerry);
            items.Add(new Item("Aspear Berry", "A sour berry that can held by a Pokémon and cure FROZE status.", (int)Enum.categorie.Berries, AspearBerryEffect, 450));
            //Lum Berry
            void LumBerry(Protagonist player)
            { cure(player, 10); }
            effect LumBerryEffect = new effect(LumBerry);
            items.Add(new Item("Lum Berry", "A tasteful berry that can held by a Pokémon and cure ANY status.", (int)Enum.categorie.Berries, LumBerryEffect, 800));

            return items;
        }
        //Function that most items will use
        private int selectPokemon(Protagonist player)
        {
            //The player is in a battle
            if(Info.inBattle)
            {

            }
            //The player is in the overwold
            else
            {

            }
            return 0;
        }
        private void writeMessage(string message)
        {
            //Player is inside a battle
            if(Info.inBattle)
            {

            }
            //Outside in the overworld
            else
            {

            }
        }
        //Healing HP
        private void heal(Protagonist player, int nbHP)
        {
            //Loop until it works or the player cancel
            bool operation = true;
            while (operation)
            {
                int choice = selectPokemon(player);

                if (player.Pokemons[choice].CurrentHP == player.Pokemons[choice].HP)
                    writeMessage("This action will have no effect.");               
                //6 is the cancel number.
                else if (choice == 6)
                    operation = false;
                else
                {
                    int difference = nbHP;
                    player.Pokemons[choice].CurrentHP += nbHP;
                    //If the CurrentHP are over its maximum HP
                    if (player.Pokemons[choice].CurrentHP > player.Pokemons[choice].HP)
                    {
                        difference = player.Pokemons[choice].CurrentHP - player.Pokemons[choice].HP;
                        player.Pokemons[choice].CurrentHP -= difference;
                    }
                    writeMessage(player.Pokemons[choice].Nickname + " has restored " + (nbHP - difference) + " HP.");
                    operation = false;
                }

            }
        }
        //Cure Status
        private void cure(Protagonist player, int status)
        {
            //Loop until it works or the player cancel
            bool operation = true;
            while (operation)
            {
                int choice = selectPokemon(player);

                if (player.Pokemons[choice].Status != status)
                    writeMessage("This action will have no effect.");
                //6 is the cancel number.
                else if (choice == 6)
                    operation = false;
                //10 is the number that cure any status
                else if (status == 10)
                {
                    player.Pokemons[choice].Status = (int)Enum.status.None;
                    writeMessage(player.Pokemons[choice].Nickname + " became healthy.");
                    operation = false;
                }
                //poison
                else if(player.Pokemons[choice].Status == (int)Enum.status.Badly_Poisoned && status == (int)Enum.status.Poisoned)
                {
                    player.Pokemons[choice].Status = (int)Enum.status.None;
                    writeMessage(player.Pokemons[choice].Nickname + " became healthy.");
                    operation = false;
                }
                else
                {
                    player.Pokemons[choice].Status = (int)Enum.status.None;
                    writeMessage(player.Pokemons[choice].Nickname + " became healthy.");
                    operation = false;
                }
            }
        }
    }
}

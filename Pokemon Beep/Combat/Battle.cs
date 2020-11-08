using Pokemon_Beep.Pokemon;
using Pokemon_Beep.Player;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Pokemon_Beep.AI;
using System.Security.Permissions;

namespace Pokemon_Beep.Combat
{
    partial class Battle
    {
        public void startWildBattle(Protagonist player, PocketMonster pocketMonster, int background)
        {
            DamageCalculator damageCalculator = new DamageCalculator();

            PkmnBattleInfo playerPokemon = new PkmnBattleInfo(getPlayerPokemon(player));
            PkmnBattleInfo wildPokemon = new PkmnBattleInfo(pocketMonster);

            Field playerField = new Field(playerPokemon);
            Field wildField = new Field(wildPokemon);

            BattleField battleField = new BattleField(playerField, wildField);

            WildPokemonAI ai = new WildPokemonAI(wildPokemon.Pokemon);      
            bool battleIsOver = false;

            //Battle Music
            Thread music = new Thread(() => Utilities.startMusic(0, 1));
            music.Start();

            //TODO Battle Animation
            //LOOP until the wild pokemon is defeated or the player doesn't have any healty pokemon left
            while (!(battleIsOver))
            {
                //Graphic
                Utilities.changeForegroundColor(255, 255, 255);
                Console.WriteLine("Weather : " + battleField.Weather);
                Console.WriteLine("------------------------------");
                Utilities.changeForegroundColor(255, 0, 0);
                Console.WriteLine(wildPokemon.Pokemon.Nickname);
                Console.WriteLine("Lv. " + wildPokemon.Pokemon.Level);
                Utilities.changeForegroundColor(0, 255, 0);
                Console.WriteLine(wildPokemon.Pokemon.CurrentHP + "/" + wildPokemon.Pokemon.HP);
                Utilities.changeForegroundColor(255, 255, 255);
                Console.WriteLine("------------------------------");
                Utilities.changeForegroundColor(0, 255, 255);
                Console.WriteLine(playerPokemon.Pokemon.Nickname);
                Console.WriteLine("Lv. " + playerPokemon.Pokemon.Level);
                Utilities.changeForegroundColor(0, 255, 0);
                Console.WriteLine(playerPokemon.Pokemon.CurrentHP + "/" + playerPokemon.Pokemon.HP);
                Utilities.changeForegroundColor(255, 255, 255);
                Console.WriteLine("------------------------------");
                Utilities.changeForegroundColor(255, 255, 0);
                Console.WriteLine("Select your move");
                for (int i = 0; i < playerPokemon.Pokemon.Moveset.Count; i++)
                {
                    Console.WriteLine(i + "- " + playerPokemon.Pokemon.Moveset[i].Name);
                }
                //Make player choose his move
                int playerChoice = Convert.ToInt32(Console.ReadLine());
                //Make the AI choose his move


                //Effect : Protagonist player, Field attacker, Field defender, int WeatherID, int foeMove, int damage, int foeDamage
                int aiChoice = ai.getChoice(playerPokemon.Pokemon);
                //The player attack first !
                if(playerAttackFirst(playerPokemon,wildPokemon, playerPokemon.Pokemon.Moveset[playerChoice], wildPokemon.Pokemon.Moveset[aiChoice]))
                {
                    int damage = damageCalculator.getDamage(playerPokemon.Pokemon, wildPokemon.Pokemon, playerPokemon.Pokemon.Moveset[playerChoice], battleField.Weather);
                    if (playerPokemon.Pokemon.Moveset[playerChoice].Power == 0)
                        playerPokemon.Pokemon.Moveset[playerChoice].Effect.DynamicInvoke(player, playerField, wildField, battleField.Weather, aiChoice, 0, 0);
                    else
                    {
                        wildPokemon.Pokemon.CurrentHP -= damage;
                        playerPokemon.Pokemon.Moveset[playerChoice].Effect.DynamicInvoke(player, playerField, wildField, battleField.Weather, aiChoice, damage, 0);
                    }
                    if(wildPokemon.Pokemon.CurrentHP <= 0)
                    {
                        Console.WriteLine("The Wild Pokemon is dead !");
                        break;
                    }
                    int foeDamage = damageCalculator.getDamage(wildPokemon.Pokemon, playerPokemon.Pokemon, wildPokemon.Pokemon.Moveset[aiChoice], battleField.Weather);
                    if (wildPokemon.Pokemon.Moveset[aiChoice].Power == 0)
                        wildPokemon.Pokemon.Moveset[aiChoice].Effect.DynamicInvoke(player, wildField, playerField, battleField.Weather, playerChoice, 0, damage);
                    else
                    {
                        playerPokemon.Pokemon.CurrentHP -= damage;
                        wildPokemon.Pokemon.Moveset[playerChoice].Effect.DynamicInvoke(player, playerField, wildField, battleField.Weather, playerChoice, foeDamage, damage);
                    }
                    if (playerPokemon.Pokemon.CurrentHP <= 0)
                    {
                        Console.WriteLine("Your Pokemon is dead !");
                        break;
                    }
                }
                //The wild Pokemon attack first !
                else
                {
                    int damage = damageCalculator.getDamage(wildPokemon.Pokemon, playerPokemon.Pokemon, wildPokemon.Pokemon.Moveset[aiChoice], battleField.Weather);
                    if (wildPokemon.Pokemon.Moveset[aiChoice].Power == 0)
                        wildPokemon.Pokemon.Moveset[aiChoice].Effect.DynamicInvoke(player, wildField, playerField, battleField.Weather, playerChoice, 0, 0);
                    else
                    {                     
                        playerPokemon.Pokemon.CurrentHP -= damage;
                        wildPokemon.Pokemon.Moveset[playerChoice].Effect.DynamicInvoke(player, playerField, wildField, battleField.Weather, playerChoice, damage, 0);
                    }
                    if (playerPokemon.Pokemon.CurrentHP <= 0)
                    {
                        Console.WriteLine("Your Pokemon is dead !");
                        break;
                    }
                    //Player turn
                    int playerDamage = damageCalculator.getDamage(playerPokemon.Pokemon, wildPokemon.Pokemon, playerPokemon.Pokemon.Moveset[playerChoice], battleField.Weather);
                    if (playerPokemon.Pokemon.Moveset[playerChoice].Power == 0)
                        playerPokemon.Pokemon.Moveset[playerChoice].Effect.DynamicInvoke(player, playerField, wildField, battleField.Weather, aiChoice, 0, damage);
                    else
                    {
                        wildPokemon.Pokemon.CurrentHP -= damage;
                        playerPokemon.Pokemon.Moveset[playerChoice].Effect.DynamicInvoke(player, playerField, wildField, battleField.Weather, aiChoice, playerDamage, damage);
                    }
                    if (wildPokemon.Pokemon.CurrentHP <= 0)
                    {
                        Console.WriteLine("The Wild Pokemon is dead !");
                        break;
                    }
                }
                Console.Clear();
            }        
        }
    }
}

using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pokemon_Beep.Player
{
    class Save
    {
        private string fileName = "SAVE.beep";

        public void init()
        {
            try
            {
                if (File.Exists(fileName))
                    loadSave();
                else
                    createSave();
            }
            catch (Exception)
            {
                Console.WriteLine("There was a error reading the save file");
                Console.ReadKey();
            }
        }
        private void loadSave()
        {

        }
        private void createSave()
        {

        }
        public void save(List<PocketMonster> pokemons)
        {
            FileStream fs = File.Create(fileName);

            string save = "[Pokemon]" + "\n";
            for (int i = 0; i < pokemons.Count; i++)
            {
                save += "<pkm" + i + ">" + "\n" +
                pokemons[i].PokedexID + "\n" +
                pokemons[i].Gender + "\n" +
                pokemons[i].Ability.Name + "\n" +
                pokemons[i].Level + "\n";
                for (int y = 0; y < pokemons[i].Moveset.Count; y++)
                {
                    save += pokemons[i].Moveset[y].Name + "\n";
                }
                save += pokemons[i].IvHP + "\n" +
                    pokemons[i].IvAttack + "\n" +
                    pokemons[i].IvDefense + "\n" +
                    pokemons[i].IvSpecialAttack + "\n" +
                    pokemons[i].IvSpecialDefense + "\n" +
                    pokemons[i].IvSpeed + "\n" +
                    pokemons[i].getNatureName() + "\n" +
                    "<pkm" + i + ">" + "\n";
            }
            
                
            //Writting the SaveFile
            byte[] ascii = Encoding.ASCII.GetBytes(save);
            foreach (byte item in ascii)
            {
                fs.WriteByte(item);
            }
            fs.Close();
        }
    }
}

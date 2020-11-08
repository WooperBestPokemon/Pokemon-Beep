using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pokemon_Beep.Player
{
    class Save
    {
        /*
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
        */
        /// <summary>
        /// Writes the given object instance to a binary file.
        /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
        /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the binary file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the binary file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object to read from the binary file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }

}

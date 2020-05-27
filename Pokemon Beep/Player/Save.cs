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
            FileStream fs = File.Create(fileName);
        }
    }
}

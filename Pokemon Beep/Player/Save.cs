using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Pokemon_Beep.Player
{
    class Save
    {
        private IFormatter formatter = new BinaryFormatter();
        public void saveGame(Protagonist player)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Pokemon_Beep.sav";
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, player);
            stream.Close();
        }
        public Protagonist loadGame()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Pokemon_Beep.sav";
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            Protagonist loadedPlayer = (Protagonist)formatter.Deserialize(stream);
            return loadedPlayer;
        }
    }
}

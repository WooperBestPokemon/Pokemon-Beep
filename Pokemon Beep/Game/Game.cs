using Pokemon_Beep.Graphic;
using Pokemon_Beep.Player;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace Pokemon_Beep.Game
{
    class Game
    {
        public void init()
        {
            Console.SetWindowSize(121, 37);
            Console.CursorVisible = false;
        }
        public void load()
        {
            //todo - load the xml save file

            //if there is no save file, create one and start new game
        }
        public void save()
        {

        }
        public void stop()
        {
            Environment.Exit(1);
        }
        public void update(int posX, int posY)
        {
            //todo - this will recieve two INT value of the GameLoop and will move the character and do all the stuff, like npc movements, wild encounter, ...

        }


        private void changeMap(int mapID, int subMapID)
        {
            //todo - change the map's background and reposition the player, then update
        }
    }
}

using Pokemon_Beep.Combat;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class World
    {
        private List<PocketMonster> pokemons = new List<PocketMonster>();
        private List<Map> maps = new List<Map>();
        private Map currentMap;
        public bool hit(int posX, int posY)
        {
            return currentMap.hit(posX, posY);
        }
        public void changeMap(int width, int height)
        {
            Console.Clear();
            Console.SetWindowSize(width, height);
        }
        public void printMap(int mapID)
        {
            //maps[mapID].printMap();
        }
    }
}

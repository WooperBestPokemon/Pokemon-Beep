using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class World
    {
        private List<Map> maps = new List<Map>();
        private Map currentMap;
        public void init()
        {
            //Map 1
            int[,] collision = new int[121, 37];
            Character[,] charact = new Character[121, 37];
            List<Building> buildings = new List<Building>();
            //buildings creation
            buildings.Add(new Building(0, 0, "border", 1));
            buildings.Add(new Building(6, 17, "decoration", 1));
            buildings.Add(new Building(39, 21, "lab", 1));
            buildings.Add(new Building(9, 5, "house", 3));
            buildings.Add(new Building(56, 5, "house", 2));
            buildings.Add(new Building(71, 21, "house", 1));
            buildings.Add(new Building(0, 0, "road", 1));
            //hitboxes
            //border
            for (int i = 0; i < 121; i++)
                collision[i, 3] = 1;
            for (int i = 0; i < 37; i++)
                collision[5, i] = 1;
            for (int i = 0; i < 20; i++)
                collision[114, i] = 1;
            for (int i = 0; i < 121; i++)
                collision[i, 32] = 1;
            for (int i = 115; i < 121; i++)
                collision[i, 19] = 1;
            for (int i = 114; i < 121; i++)
                collision[i, 24] = 1;
            for (int i = 24; i < 37; i++)
                collision[114, i] = 1;
            //Lab
            for (int i = 39; i < 47; i++)
                collision[i, 26] = 1;
            for (int i = 48; i < 56; i++)
                collision[i, 26] = 1;
            for (int i = 39; i < 56; i++)
                collision[i, 22] = 1;
            for (int i = 22; i < 26; i++)
                collision[39, i] = 1;
            for (int i = 22; i < 26; i++)
                collision[55, i] = 1;
            //Player Home
            for (int i = 8; i < 12; i++)
                collision[10, i] = 1;
            for (int i = 10; i < 30; i++)
                collision[i, 6] = 1;
            for (int i = 7; i < 12; i++)
                collision[30, i] = 1;
            for (int i = 15; i < 31; i++)
                collision[i, 11] = 1;
            for (int i = 10; i < 14; i++)
                collision[i, 11] = 1;
            collision[23, 5] = 1;
            collision[24, 5] = 1;
            collision[9, 7] = 1;
            //NPC house 1
            for (int i = 57; i < 63; i++)
                collision[i, 11] = 1;
            for (int i = 64; i < 79; i++)
                collision[i, 11] = 1;
            for (int i = 57; i < 79; i++)
                collision[i, 10] = 1;
            for (int i = 57; i < 79; i++)
                collision[i, 9] = 1;
            for (int i = 57; i < 79; i++)
                collision[i, 8] = 1;
            for (int i = 58; i < 78; i++)
                collision[i, 7] = 1;
            for (int i = 70; i < 74; i++)
                collision[i, 6] = 1;
            //NPC house 2
            for (int i = 72; i < 92; i++)
            {
                for (int y = 23; y < 27; y++)
                    collision[i, y] = 1;
            }
            for (int i = 73; i < 91; i++)
                collision[i, 22] = 1;

            collision[78, 26] = 0;
            //Characters----------------------------------------
            for (int i = 0; i < 121; i++)
            {
                charact[i, 0] = new Character(' ', "black");
                for (int y = 0; y < 37; y++)
                    charact[i,y] = new Character(' ', "black");
            }
            for (int i = 11; i < 23; i++)
                charact[i, 5] = new Character('_', "white");
            for (int i = 25; i < 29; i++)
                charact[i, 5] = new Character('_', "white");
            for (int i = 40; i < 55; i++)
                charact[i, 21] = new Character('_', "white");
            for (int i = 74; i < 90; i++)
                charact[i, 21] = new Character('_', "white");
            for (int i = 74; i < 77; i++)
                charact[i, 6] = new Character('_', "white");
            for (int i = 59; i < 70; i++)
                charact[i, 6] = new Character('_', "white");

            charact[71, 5] = new Character('_', "white");
            charact[72, 5] = new Character('_', "white");
            charact[14, 11] = new Character('_', "white");
            charact[63, 11] = new Character('_', "white");
            charact[47, 26] = new Character('_', "white");
            charact[78, 26] = new Character('_', "white");

            for (int i = 37; i < 108; i++)
            {
                for (int y = 27; y < 30; y++)
                {
                    charact[i, y] = new Character('░', "darkYellow");
                }
            }
            for (int i = 103; i < 108; i++)
            {
                for (int y = 12; y < 27; y++)
                {
                    charact[i, y] = new Character('░', "darkYellow");
                }
            }
            for (int i = 10; i < 103; i++)
            {
                for (int y = 12; y < 15; y++)
                {
                    charact[i, y] = new Character('░', "darkYellow");
                }
            }
            for (int i = 108; i < 121; i++)
            {
                for (int y = 21; y < 24; y++)
                {
                    charact[i, y] = new Character('░', "darkYellow");
                }
            }
            maps.Add(new Map(1, 0, buildings, new Hitbox(collision), charact));
            currentMap = maps[0];            
        }
        public bool hit(int posX, int posY)
        {
            return currentMap.hit(posX, posY);
        }
        public void changeMap(int mapID, int submapID, int nbLine)
        {
            clearScreen(nbLine);
        }
        private void clearScreen(int nbLine)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < nbLine; i++)
            {
                Console.WriteLine("                                                                                                                        ");
            }           
        }
        public void printMap(int mapID)
        {
            maps[mapID].printMap();
        }
        public void printOldCharacter(int posX, int posY)
        {
            currentMap.printOldCharacter(posX, posY);
        }
    }
}

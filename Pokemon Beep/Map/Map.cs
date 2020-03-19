using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Map
    {
        private int mapID, submapID;
        private List<Building> buildings = new List<Building>();
        Character[,] characters;
        private Hitbox hitbox;
        public Map(int mapID, int submapID, List<Building> buildings, Hitbox hitbox, Character[,] characters)
        {
            this.mapID = mapID;
            this.submapID = submapID;
            this.buildings = buildings;
            this.hitbox = hitbox;
            this.characters = characters;
        }
        public bool hit(int posX, int posY)
        {
            if (hitbox.returnCollision(posX, posY) == 1)
                return true;
            else
                return false;
        }
        public void printMap()
        {
            for (int i = 0; i < buildings.Count; i++)
            {
                buildings[i].writeBuilding();
            }
        }
        public void printOldCharacter(int posX, int posY)
        {
            Char character = characters[posX, posY].Charact;
            if(character != ' ')
            {
                Console.SetCursorPosition(posX, posY);
                switch (characters[posX, posY].Color)
                {
                    case "black":
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "darkBlue":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case "darkGreen":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case "darkCyan":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "darkRed":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "darkMagenta":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case "darkYellow":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "gray":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "darkGray":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "cyan":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "magenta":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "white":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.Write(characters[posX, posY].Charact);
            }           
        }
    }
}

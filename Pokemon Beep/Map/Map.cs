using Pokemon_Beep.Graphic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Map
    {
        private Camera cam;
        private int mapID, submapID;
        private List<Building> buildings = new List<Building>();
        Background background;
        private Hitbox hitbox;
        public Map(int mapID, int submapID, List<Building> buildings, Hitbox hitbox, Background background)
        {
            this.mapID = mapID;
            this.submapID = submapID;
            this.buildings = buildings;
            this.hitbox = hitbox;
            this.background = background;
            cam = new Camera(background);
        }
        public bool hit(int posX, int posY)
        {
            if (hitbox.returnCollision(posX, posY) == 1)
                return true;
            else
                return false;
        }
        public void printMap(int posX, int posY)
        {
            cam.printBackground(posX, posY);
        }
    }
}

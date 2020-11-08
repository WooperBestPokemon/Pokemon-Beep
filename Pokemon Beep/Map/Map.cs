using Pokemon_Beep.Graphic;
using Pokemon_Beep.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Map
    {
        private Camera cam;
        private int mapID, submapID;
        private Background background;
        private Hitbox hitbox;
        private Animation animation = new Animation();
        public Map(int mapID, int submapID, Hitbox hitbox, Background background)
        {
            this.mapID = mapID;
            this.submapID = submapID;
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
        public void wildPokemon(int posX, int posY)
        {
            if (hitbox.returnCollision(posX, posY) == 2)
            {
                if(Utilities.RandomNumber(1,10) == 1)
                {
                    animation.wildPokemonBattleAnimation();
                }
            }
        }
    }
}

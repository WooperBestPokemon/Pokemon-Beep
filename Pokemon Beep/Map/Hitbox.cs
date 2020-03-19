using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Hitbox
    {
        private int[,] collision;
        public Hitbox(int[,] collision)
        {
            this.collision = collision;
        }
        public int returnCollision(int posX, int posY)
        {
            return collision[posX, posY];
        }
    }
}

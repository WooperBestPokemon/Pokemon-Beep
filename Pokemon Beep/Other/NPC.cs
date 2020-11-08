using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Other
{
    class NPC
    {
        private Item item;
        public NPC(string name, string dialoge, int posX, int posY)
        {
            Name = name;
            Dialoge = dialoge;
            PosX = posX;
            PosY = posY;
            Move = false;
        }
        public NPC(string name, string dialoge, int posX, int posY, bool move)
        {
            Name = name;
            Dialoge = dialoge;
            PosX = posX;
            PosY = posY;
            Move = move;
        }
        public NPC(string name, string dialoge, int posX, int posY, Item item)
        {
            Name = name;
            Dialoge = dialoge;
            PosX = posX;
            PosY = posY;
            Move = false;
            this.item = item;
        }
        public NPC(string name, string dialoge, int posX, int posY, bool move, Item item)
        {
            Name = name;
            Dialoge = dialoge;
            PosX = posX;
            PosY = posY;
            Move = move;
            this.item = item;
        }
        public string Name { get; }
        public string Dialoge { get; }

        public int PosX { get; }
        public int PosY { get; }
        public bool Move { get; }
        public void MoveNPC()
        {
            if(Move)
            {
                int randomChance = 3;
                if(Utilities.RandomNumber(1, randomChance + 1) == 1)
                {
                    //todo - move the posX or posY and check collision if he can move. The NPC will be able to move pretty much everyhere.
                    //I will need to make sure the npc is not blocking a path cause it's super annoying when it happens
                }
            }
        }
        //todo - code a way to give the item to the players, then remove the item from the NPC's inventory
    }
}

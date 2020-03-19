using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Game
    {
        private Audio audio = new Audio();
        private World world = new World();
        public void init()
        {
            Console.SetWindowSize(121, 37);
            Console.CursorVisible = false;
            audio.init();
            world.init();
        }
        public void play()
        {

        }
    }
}

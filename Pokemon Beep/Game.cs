using Pokemon_Beep.Player;
using Pokemon_Beep.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Beep
{
    class Game
    {
        private Audio audio = new Audio();
        private World world = new World();
        private Save save = new Save();
        public void init()
        {
            Console.SetWindowSize(121, 37);
            Console.CursorVisible = false;
            audio.init();
            world.init();
            save.init();
        }
        public void play()
        {

        }
    }
}

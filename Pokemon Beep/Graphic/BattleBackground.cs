using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Graphic
{
    class BattleBackground
    {
        public BattleBackground()
        {  }
        public void writeBackground(int id)
        {
            Console.SetCursorPosition(0, 0);

            switch (id)
            {
                case 1:
                    //Normal Background
                    print("Ressource/Background/Default.png");
                    break;
                case 2:
                    //Forest Day
                    print("Ressource/Background/Forest - Day.png");
                    break;
                case 3:
                    //Forest Night
                    print("Ressource/Background/Forest - Night.png");
                    break;
                case 4:
                    //City Day
                    print("Ressource/Background/City - Day.png");

                    break;
                case 5:
                    //City Night
                    print("Ressource/Background/City - Night.png");

                    break;
                case 6:
                    //cave
                    print("Ressource/Background/Cave.png");
                    break;
                default:
                    //Windows XP
                    print("Ressource/Background/WindowsXP.png");
                    break;
            }
        }
        private void print(string path)
        {

        }
    }
}

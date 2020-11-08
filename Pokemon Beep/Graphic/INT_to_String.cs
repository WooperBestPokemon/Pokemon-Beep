using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Graphic
{
    class INT_to_String
    {
        public string getNatureName(int nature)
        {
            string result = "Error";
            switch (nature)
            {
                case 0:
                    result = "Adamant";
                    break;
                case 1:
                    result = "Bashful";
                    break;
                case 2:
                    result = "Bold";
                    break;
                case 3:
                    result = "Brave";
                    break;
                case 4:
                    result = "Calm";
                    break;
                case 5:
                    result = "Careful";
                    break;
                case 6:
                    result = "Docile";
                    break;
                case 7:
                    result = "Gentle";
                    break;
                case 8:
                    result = "Hardy";
                    break;
                case 9:
                    result = "Hasty";
                    break;
                case 10:
                    result = "Impish";
                    break;
                case 11:
                    result = "Jolly";
                    break;
                case 12:
                    result = "Lax";
                    break;
                case 13:
                    result = "Lonely";
                    break;
                case 14:
                    result = "Mild";
                    break;
                case 15:
                    result = "Modest";
                    break;
                case 16:
                    result = "Naive";
                    break;
                case 17:
                    result = "Naughty";
                    break;
                case 18:
                    result = "Quiet";
                    break;
                case 19:
                    result = "Quirky";
                    break;
                case 20:
                    result = "Rash";
                    break;
                case 21:
                    result = "Relaxed";
                    break;
                case 22:
                    result = "Sassy";
                    break;
                case 23:
                    result = "Serious";
                    break;
                case 24:
                    result = "Timid";
                    break;
            }
            return result;
        }
        public string getStatusName(int status)
        {
            string result = "Null";
            switch (status)
            {
                case 1:
                    result = "Poisoned";
                    break;
                case 2:
                    result = "Badly Poisoned";
                    break;
                case 3:
                    result = "Paralyzed";
                    break;
                case 4:
                    result = "Sleep";
                    break;
                case 5:
                    result = "Frozen";
                    break;
                case 6:
                    result = "Burned";
                    break;
            }
            return result;
        }
    }
}

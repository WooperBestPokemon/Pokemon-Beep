using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Beep.Factory
{
    class BackgroundFactory
    {
        public List<Background> GetBackgrounds()
        {
            List<Background> backgrounds = new List<Background>();

            backgrounds.Add(getBackground("Ressource/Background/WindowsXP.png"));
            backgrounds.Add(getBackground("Ressource/Background/Default.png"));
            backgrounds.Add(getBackground("Ressource/Background/Forest - Day.png"));
            backgrounds.Add(getBackground("Ressource/Background/Forest - Night.png"));
            backgrounds.Add(getBackground("Ressource/Background/City - Day.png"));
            backgrounds.Add(getBackground("Ressource/Background/City - Night.png"));
            backgrounds.Add(getBackground("Ressource/Background/Cave.png"));

            return backgrounds;
        }

        private Background getBackground(string path)
        {
            Bitmap bmp = new Bitmap(path);

            int height = bmp.Height;
            int width = bmp.Width;

            char[,] character = new char[width * 2, height];
            string[,] colours = new string[width * 2, height];

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);

                    int posX = x * 2;

                    char pixel = '█';
                    string color = "\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m";

                    character[posX - 1, y] = pixel;
                    character[posX, y] = pixel;

                    colours[posX - 1, y] = color;
                    colours[posX, y] = color;
                }
            }
            return new Background(character, colours);
        }
    }
}

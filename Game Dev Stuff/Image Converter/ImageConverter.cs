using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageConverter
{
    class ImageConverter
    {
        /// <summary>
        /// A small script that read a pixel art picture and translate it into c# console ascii
        /// </summary>
        public void convertImage(string filename)
        {
            Optimiser optimiser = new Optimiser();
            Bitmap bmp = new Bitmap("Images\\" + filename + ".png");
            List<String> pokemons = new List<string>();
            for (int y = 0; y < bmp.Height; y++)
            {
                string line = "";
                //string line = "Console.WriteLine(";
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    //The background color, it will be replace by a pixel of nothing
                    if(pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216 && (x != (bmp.Width - 1)))
                    {
                        line += "\"  \" + ";
                    }
                    else if (pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216)
                    {
                        line += "\"  ";
                    }
                    else if(x == (bmp.Width - 1))
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██";
                    }
                    else
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██\" + ";
                    }
                }
                //line += "\");";
                pokemons.Add(line);
            }
            pokemons = optimiser.optimiseLines(pokemons);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("Output\\" + filename + ".txt"))
            {
                for (int i = 0; i < pokemons.Count; i++)
                {
                    file.WriteLine(pokemons[i]);
                }
            }
        }
    }
}
//R : 179, G : 186, B: 216
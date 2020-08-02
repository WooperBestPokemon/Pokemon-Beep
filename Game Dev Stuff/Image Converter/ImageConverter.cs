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
            convertImageRight(filename);
            convertImageLeft(filename);
            //upsiteDown(filename);
        }
        private void convertImageRight(string filename)
        {
            Optimiser optimiser = new Optimiser();
            Bitmap bmp = new Bitmap(filename);

            filename = filename.Replace("Images\\", "");
            filename = filename.Remove(filename.Length - 4);

            List<string> pokemons = new List<string>();
            for (int y = 0; y < bmp.Height; y++)
            {
                string line = "";
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    //The background color, it will be replace by a pixel of nothing
                    if (pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216 && (x != (bmp.Width - 1)))
                    {
                        line += "\"  \" + ";
                    }
                    else if (pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216)
                    {
                        line += "\"  ";
                    }
                    else if (x == (bmp.Width - 1))
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██";
                    }
                    else
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██\" + ";
                    }
                }
                pokemons.Add(line);
            }
            pokemons = optimiser.optimiseLines(pokemons);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("Output\\" + filename + "_Right.txt"))
            {
                for (int i = 0; i < pokemons.Count; i++)
                {
                    file.WriteLine(pokemons[i]);
                }
            }
        }
        private void convertImageLeft(string filename)
        {
            Optimiser optimiser = new Optimiser();
            Bitmap bmp = new Bitmap(filename);

            filename = filename.Replace("Images\\", "");
            filename = filename.Remove(filename.Length - 4);

            List<string> pokemons = new List<string>();
            for (int y = 0; y < bmp.Height; y++)
            {
                string line = "";
                for (int x = (bmp.Width-1); x > 0; x--)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    //The background color, it will be replace by a pixel of nothing
                    if (pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216 && (x != (0)))
                    {
                        line += "\"  \" + ";
                    }
                    else if (pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216)
                    {
                        line += "\"  ";
                    }
                    else if (x == 0)
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██";
                    }
                    else
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██\" + ";
                    }
                }
                pokemons.Add(line);
            }
            pokemons = optimiser.optimiseLines(pokemons);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("Output\\" + filename + "_Left.txt"))
            {
                for (int i = 0; i < pokemons.Count; i++)
                {
                    file.WriteLine(pokemons[i]);
                }
            }
        }
        private void upsiteDown(string filename)
        {
            Optimiser optimiser = new Optimiser();
            Bitmap bmp = new Bitmap(filename);

            filename = filename.Replace("Images\\", "");
            filename = filename.Remove(filename.Length - 4);

            List<string> pokemons = new List<string>();
            for (int y = (bmp.Height - 1); y > 0; y--)
            {
                string line = "";
                for (int x = (bmp.Width - 1); x > 0; x--)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    //The background color, it will be replace by a pixel of nothing
                    if (pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216 && (x != (0)))
                    {
                        line += "\"  \" + ";
                    }
                    else if (pixelColor.R == 179 && pixelColor.G == 186 && pixelColor.B == 216)
                    {
                        line += "\"  ";
                    }
                    else if (x == 0)
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██";
                    }
                    else
                    {
                        line += "\"\\x1b[38;2;" + pixelColor.R + ";" + pixelColor.G + ";" + pixelColor.B + "m\" + \"██\" + ";
                    }
                }
                pokemons.Add(line);
            }
            pokemons = optimiser.optimiseLines(pokemons);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("Output\\" + filename + "_UpsideDown.txt"))
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
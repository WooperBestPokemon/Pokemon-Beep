using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Pokemon_Beep.Factory
{
    class MapFactory
    {
        public List<Hitbox> getHitboxes()
        {
            List<Hitbox> hitboxes = new List<Hitbox>();

            //Plankalkul + road 1
            hitboxes.Add(getHitbox("Pokemon_Beep.Data.Map.Plankalkul&Road1Hitbox.png"));



            return hitboxes;
        }
        private Hitbox getHitbox(string path)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream(path);
            Bitmap bmp = new Bitmap(myStream);

            int height = bmp.Height;
            int width = bmp.Width;

            int[,] collision = new int[width, height];

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    //Cannot Move
                    if (pixelColor.R == 255 && pixelColor.G == 0 && pixelColor.B == 110)
                        collision[x, y] = 1;
                    //Grass
                    else if (pixelColor.R == 182 && pixelColor.G == 255 && pixelColor.B == 0)
                        collision[x, y] = 2;
                    //Water
                    else if(pixelColor.R == 0 && pixelColor.G == 255 && pixelColor.B == 255)
                        collision[x, y] = 3;
                    //Warp
                    else if (pixelColor.R == 255 && pixelColor.G == 216 && pixelColor.B == 0)
                        collision[x, y] = 4;
                    //Slopes
                    else if (pixelColor.R == 255 && pixelColor.G == 0 && pixelColor.B == 50)
                        collision[x, y] = 5;
                    else if (pixelColor.R == 255 && pixelColor.G == 0 && pixelColor.B == 25)
                        collision[x, y] = 6;
                    else if (pixelColor.R == 255 && pixelColor.G == 200 && pixelColor.B == 0)
                        collision[x, y] = 7;
                    else if (pixelColor.R == 255 && pixelColor.G == 100 && pixelColor.B == 0)
                        collision[x, y] = 8;
                    //Nothing
                    else
                        collision[x, y] = 0;
                }
            }
            return new Hitbox(collision);
        }
    }
}

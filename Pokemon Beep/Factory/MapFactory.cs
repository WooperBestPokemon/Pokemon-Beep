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
        public List<Map> getMaps()
        {
            List<Map> maps = new List<Map>();

            return maps;
        }
        public List<Background> getBackground()
        {
            List<Background> backgrounds = new List<Background>();
            backgrounds.Add(getBackground("Pokemon_Beep.Data.Map.Plankalkul&Road1.png"));

            return backgrounds;
        }
        private List<Hitbox> getHitboxes()
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

            int[,] collision = new int[width * 2, height];

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    //Cannot Move
                    if (pixelColor.R == 255 && pixelColor.G == 0 && pixelColor.B == 110)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 1;
                        collision[posX, y] = 1;
                    }
                    //Grass
                    else if (pixelColor.R == 182 && pixelColor.G == 255 && pixelColor.B == 0)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 2;
                        collision[posX, y] = 2;
                    }
                    //Water
                    else if(pixelColor.R == 0 && pixelColor.G == 255 && pixelColor.B == 255)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 3;
                        collision[posX, y] = 3;
                    }
                    //Warp
                    else if (pixelColor.R == 255 && pixelColor.G == 216 && pixelColor.B == 0)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 4;
                        collision[posX, y] = 4;
                    }
                    //Slopes
                    else if (pixelColor.R == 255 && pixelColor.G == 0 && pixelColor.B == 50)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 5;
                        collision[posX, y] = 5;
                    }
                    else if (pixelColor.R == 255 && pixelColor.G == 0 && pixelColor.B == 25)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 6;
                        collision[posX, y] = 6;
                    }
                    else if (pixelColor.R == 255 && pixelColor.G == 200 && pixelColor.B == 0)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 7;
                        collision[posX, y] = 7;
                    }
                    else if (pixelColor.R == 255 && pixelColor.G == 100 && pixelColor.B == 0)
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 8;
                        collision[posX, y] = 8;
                    }
                    //Nothing
                    else
                    {
                        int posX = x * 2;
                        collision[posX - 1, y] = 0;
                        collision[posX, y] = 0;
                    }
                }
            }
            return new Hitbox(collision);
        }
        private Background getBackground(string path)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream(path);
            Bitmap bmp = new Bitmap(myStream);

            int height = bmp.Height;
            int width = bmp.Width;

            char[,] character = new char[width * 2, height];
            string[,] colours = new string[width * 2, height];

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    //Step 1 : Grass
                    if (pixelColor.R == 182 && pixelColor.G == 255 && pixelColor.B == 0)
                    {
                        int posX = x * 2;

                        char grass = '#';
                        string grassColour = "\x1b[38;2;109;192;103m";

                        character[posX - 1, y] = grass;
                        character[posX, y] = grass;

                        colours[posX - 1, y] = grassColour;
                        colours[posX, y] = grassColour;
                    }
                    //Step 2 : Trees
                    else if (pixelColor.R == 127 && pixelColor.G == 51 && pixelColor.B == 0)
                    {
                        //Calculate how much there is green pixel
                        int nbGreenPixel = 0;

                        bool noMoreGreenPixel = false;
                        int posY = y - 1;

                        while (!(noMoreGreenPixel) && posY != -1)
                        {
                            Color color = bmp.GetPixel(x, posY);
                            if (color.R == 38 && color.G == 127 && color.B == 0)
                                nbGreenPixel++;
                            else
                                noMoreGreenPixel = true;
                            posY--;
                        }
                        //Calculate how much tree there is stacked over each other
                        double nb = nbGreenPixel / 2;
                        int nbTree = (int)Math.Truncate(nb);

                        string leavesColour = "\x1b[38;2;22;76;0m";
                        string treeColour = "\x1b[38;2;63;25;0m";

                        int posX = x * 2;
                        posY = y;

                        colours[posX, posY] = treeColour;
                        colours[posX - 1, posY] = treeColour;

                        character[posX, posY] = '(';
                        character[posX - 1, posY] = ')';

                        posY--;

                        colours[posX - 3, posY] = leavesColour;
                        colours[posX - 2, posY] = leavesColour;
                        colours[posX - 1, posY] = leavesColour;
                        colours[posX, posY] = leavesColour;
                        colours[posX + 1, posY] = leavesColour;
                        colours[posX + 2, posY] = leavesColour;

                        character[posX - 3, posY] = '{';
                        character[posX - 2, posY] = '_';
                        character[posX - 1, posY] = '_';
                        character[posX, posY] = '_';
                        character[posX + 1, posY] = '_';
                        character[posX + 2, posY] = '}';

                        posY--;

                        for (int i = nbTree; i > 0; i--)
                        {
                            //Last tree in the row
                            if(i == 1)
                            {
                                colours[posX - 2, posY] = leavesColour;
                                colours[posX + 1, posY] = leavesColour;

                                character[posX - 2, posY] = '{';
                                character[posX + 1, posY] = '}';
                                posY--;

                                int tellMeX = posX;
                                int tellMeY = posY;

                                colours[posX - 1, posY] = leavesColour;
                                colours[posX, posY] = leavesColour;

                                character[posX - 1, posY] = '(';
                                character[posX, posY] = ')';
                            }
                            else
                            {
                                colours[posX - 2, posY] = leavesColour;
                                colours[posX + 1, posY] = leavesColour;

                                character[posX - 2, posY] = '{';
                                character[posX + 1, posY] = '}';
                                posY--;

                                colours[posX - 3, posY] = leavesColour;
                                colours[posX - 1, posY] = leavesColour;
                                colours[posX, posY] = leavesColour;
                                colours[posX + 2, posY] = leavesColour;

                                character[posX - 3, posY] = '{';
                                character[posX - 1, posY] = '(';
                                character[posX, posY] = ')';
                                character[posX + 2, posY] = '}';
                                posY--;
                            }
                        }

                    }
                    //Roads
                    else if (pixelColor.R == 255 && pixelColor.G == 216 && pixelColor.B == 0)
                    {
                        int posX = x * 2;

                        char road = '░';
                        string roadColour = "\x1b[38;2;255;216;0m";

                        character[posX - 1, y] = road;
                        character[posX, y] = road;

                        colours[posX - 1, y] = roadColour;
                        colours[posX, y] = roadColour;
                    }
                    //Water
                    else if (pixelColor.R == 0 && pixelColor.G == 148 && pixelColor.B == 255)
                    {
                        int posX = x * 2;

                        char water = '█';
                        string waterColour = "\x1b[38;2;0;126;216m";

                        character[posX - 1, y] = water;
                        character[posX, y] = water;

                        colours[posX - 1, y] = waterColour;
                        colours[posX, y] = waterColour;
                    }
                    //splash Water
                    else if (pixelColor.R == 0 && pixelColor.G == 19 && pixelColor.B == 127)
                    {
                        int posX = x * 2;

                        char water = '█';
                        string waterColour = "\x1b[38;2;0;148;255m";

                        character[posX - 1, y] = water;
                        character[posX, y] = water;

                        colours[posX - 1, y] = waterColour;
                        colours[posX, y] = waterColour;
                    }
                }
            }

            return new Background(character, colours);
        }
    }
}

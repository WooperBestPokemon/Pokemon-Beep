using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles("Images\\");
            ImageConverter imageConverter = new ImageConverter();

            foreach(string str in filePaths)
            {
                imageConverter.convertImage(str);
            }
        }
    }
}

using System;
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
            ImageConverter imageConverter = new ImageConverter();
            imageConverter.convertImage("Dunsparce_S");
        }
    }
}

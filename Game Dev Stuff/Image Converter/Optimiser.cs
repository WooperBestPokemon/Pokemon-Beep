using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageConverter
{
    class Optimiser
    {
        public List<string> optimiseLines(List<string> lines)
        {
            List<string> optLines = new List<string>();

            for (int i = 0; i < lines.Count; i++)
            {
                //Removes the " + "
                string newLine = removeTheAddition(lines[i]);
                //Remove the empty space after the last character
                newLine = deleteEmptyEnding(newLine);
                //Fuse Pixels with the same Color
                //newLine = fusePixel(newLine);
                //Add the Console.WriteLine to the Line
                newLine = addCommand(newLine);
                optLines.Add(newLine);
            }
                
            return optLines;
        }
        private string removeTheAddition(string line)
        {
            return line.Replace("\" + \"", "");
        }
        private string deleteEmptyEnding(string line)
        {
            string newLine = "";
            int charIndex = line.LastIndexOf('█');

            newLine += line.Remove(charIndex);
            newLine += "█";
            return newLine;
        }
        private string addCommand(string line)
        {
            return "Console.WriteLine(" + line + "\");";
        }
        private string fusePixel(string line)
        {
            string newLine = "";
            String[] splitted = line.Split('\\');
            List<string> splittedList = new List<string>();
            for (int i = 0; i < splitted.Length; i++)
                splittedList.Add(splitted[i]);
            for (int i = 0; i < splittedList.Count; i++)
            {
                splittedList[i] = splittedList[i].Replace(" ", "-");
            }

            int bidon = 1;
            for (int i = 0; i < splittedList.Count; i++)
            {
                if(i != (splittedList.Count -1))
                {
                    if(splittedList[i] == splittedList[bidon])
                    {
                        int start = splittedList[i].IndexOf('[');
                        start++;
                        int end = splittedList[i].LastIndexOf('m');

                        string result = splittedList[i].Substring(start, end - start);
                        splittedList[i] = "\x1b[" + result + "m" + "████";
                        splittedList.Remove(splittedList[bidon]);
                    }
                    bidon++;
                }               
            }
            for (int i = 0; i < splittedList.Count; i++)
            {
                if(splittedList[i].IndexOf('x') == 0)                
                    splittedList[i] = "\\" + splittedList[i];
            }

            for (int i = 0; i < splittedList.Count; i++)
                newLine += splittedList[i];

            return newLine.Replace("", "\\x1b");
        }
    }
}

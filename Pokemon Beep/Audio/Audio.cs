using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using NAudio.Wave;

namespace Pokemon_Beep
{
    class Audio
    {
        private List<AudioFileReader> backgroundMusic = new List<AudioFileReader>();
        WaveOutEvent output = new WaveOutEvent();
        public void init()
        {
            backgroundMusic.Add(new AudioFileReader("music/Prof.mp3"));
            backgroundMusic.Add(new AudioFileReader("music/City1.mp3"));           
        }
        public void music(string name)
        {
            int musidId;
            switch(name)
            {
                case "Prof":
                    musidId = 0;
                    break;
                case "City1":
                    musidId = 1;
                    break;              
                default:
                    musidId = 0;
                    break;
            }
            LoopStream loop = new LoopStream(backgroundMusic[musidId]);
            output.Init(loop);
            output.Play();
        }
    }
}

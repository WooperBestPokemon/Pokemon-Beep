using NAudio.Wave;
using NAudio.Vorbis;
using System.Threading;
using System.Collections.Generic;

namespace Pokemon_Beep
{
    class Audio
    {
        List<VorbisWaveReader> musics = new List<VorbisWaveReader>();
        WaveOut waveOutIntro = new WaveOut();
        WaveOut waveOutLoop = new WaveOut();
        public void init()
        {
            musics.Add(new VorbisWaveReader("Audio/test_battleintro.ogg"));
            musics.Add(new VorbisWaveReader("Audio/test_battleloop.ogg"));
            musics.Add(new VorbisWaveReader("Audio/test_roadintro.ogg"));
            musics.Add(new VorbisWaveReader("Audio/test_roadloop.ogg"));

            waveOutIntro.Volume = (float)0.5;
            waveOutLoop.Volume = (float)0.5;
        }
        public void ChangeMusic(int musicID)
        {
            //Fade
            for (int i = 0; i < 20; i++)
            {
                waveOutIntro.Volume -= (float)0.01;
                waveOutLoop.Volume -= (float)0.01;
                Thread.Sleep(50);
            }
            
            waveOutIntro.Pause();
            waveOutLoop.Pause();
            waveOutIntro.Dispose();
            waveOutLoop.Dispose();

            LoopStream loopStream = new LoopStream(musics[musicID]);
            loopStream.EnableLooping = true;

            waveOutLoop.Init(loopStream);
            waveOutLoop.Volume = (float)0.5;
            waveOutLoop.Play();
        }
        public void ChangeMusic(int musicIDIntro, int musicIDLoop)
        {
            //Fade
            for (int i = 0; i < 4; i++)
            {
                waveOutIntro.Volume -= (float)0.05;
                waveOutLoop.Volume -= (float)0.05;
                Thread.Sleep(100);
            }

            waveOutIntro.Pause();
            waveOutLoop.Pause();
            waveOutIntro.Dispose();
            waveOutLoop.Dispose();

            LoopStream loopStream = new LoopStream(musics[musicIDLoop]);
            loopStream.EnableLooping = true;

            waveOutIntro.Init(musics[musicIDIntro]);
            waveOutLoop.Init(loopStream);

            waveOutIntro.Volume = (float)0.5;
            waveOutLoop.Volume = (float)0.5;
            waveOutIntro.Play();

            while (waveOutIntro.PlaybackState != PlaybackState.Stopped) ;
            waveOutLoop.Play();
        }
        public void startMusic(int musicID)
        {
            LoopStream loopStream = new LoopStream(musics[musicID]);
            loopStream.EnableLooping = true;

            waveOutLoop.Init(loopStream);
            waveOutLoop.Play();
        }
        public void startMusic(int musicIDIntro, int musicIDLoop)
        {
            LoopStream loopStream = new LoopStream(musics[musicIDLoop]);
            loopStream.EnableLooping = true;

            waveOutIntro.Init(musics[musicIDIntro]);
            waveOutLoop.Init(loopStream);

            waveOutIntro.Play();

            while (waveOutIntro.PlaybackState != PlaybackState.Stopped) ;
            waveOutLoop.Play();
        }
    }
}

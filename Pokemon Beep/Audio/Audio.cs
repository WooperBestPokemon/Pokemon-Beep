using NAudio.Wave;
using NAudio.Vorbis;
using System.Collections.Generic;

namespace Pokemon_Beep
{
    class Audio
    {
        List<VorbisWaveReader> musics = new List<VorbisWaveReader>();
        public void testUwU()
        {
            var intro = new VorbisWaveReader("Audio/intro.ogg");
            var loop = new VorbisWaveReader("Audio/loop.ogg");
            var waveOut = new DirectSoundOut(); // or WaveOutEvent()
            var waveOut2 = new DirectSoundOut();
            LoopStream loopStream = new LoopStream(loop);
            loopStream.EnableLooping = true;
            waveOut.Init(intro);
            waveOut2.Init(loopStream);
            waveOut.Play();
            while (waveOut.PlaybackState != PlaybackState.Stopped) ;
            waveOut2.Play();
            
            
        }
        public void init()
        {

        }
    }
}

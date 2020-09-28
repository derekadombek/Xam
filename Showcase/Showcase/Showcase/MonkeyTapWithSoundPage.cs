using System.Collections.Generic;

namespace Showcase
{
    class MonkeyTapWithSoundPage : Showcase.MonkeyTapPage
    {
        const int errorDuration = 500;

        // Diminished 7th in 1st inversion: C, Eb, F#, A
        double[] frequencies = { 523.25, 622.25, 739.99, 880 };
        double endFrequency = 65.4;

        List<byte[]> buffers;
        byte[] endBuffer;

        public MonkeyTapWithSoundPage()
        {
            buffers = new List<byte[]>();
            for(int i=0; i < frequencies.Length; i++)
            {
                byte[] buffer = SoundPlayer.MakeBuffer(frequencies[i], flashDuration);
                buffers.Add(buffer);
            }
            endBuffer = SoundPlayer.MakeBuffer(endFrequency, errorDuration);
            
        }


        protected override void FlashBoxView(int index)
        {
            SoundPlayer.PlayBufferSound(buffers[index]);
            base.FlashBoxView(index);
        }

        protected override void EndGame()
        {
            SoundPlayer.PlayBufferSound(endBuffer);
            base.EndGame();
        }
    }
}

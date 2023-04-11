// PUBLISHER
using System;
namespace tryEventHandler
{
    public class VideoEncoder
    {
        // 1. Buat delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2. Buat event yang membungkus delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video....");
            Thread.Sleep(2000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}


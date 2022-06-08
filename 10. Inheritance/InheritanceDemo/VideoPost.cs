using System;
using System.Threading;

namespace InheritanceDemo
{
    public class VideoPost : Post
    {
        // member fields
        public bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        // properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.Length = length;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - link: {2} - duration: {3}seconds - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }

        public void PlayVideo()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                timer = new Timer(TimerCallback, null, 0, 1000);
                Console.WriteLine("Playing...");

            }
        }

        private void TimerCallback(Object o)
        {
            if(currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0} seconds", currentDuration);
                GC.Collect();
            }
            else
            {
                StopVideo();
            }
        }

        public void StopVideo()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
        }
    }
}

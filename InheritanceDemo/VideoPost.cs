using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class VideoPost : Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;
        public string VideoUrl { get; set; }

        public double Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoUrl,double length, bool isPublic)
        {
            this.ID = getNextID();
            this.Title = title;
            this.VideoUrl = videoUrl;
            this.Length = length;
            this.SendByUsername= sendByUsername;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} mins by {4}", this.ID, this.Title, this.VideoUrl, this.Length, this.SendByUsername);
        }

        public void Play()
        {
            if (!this.isPlaying)
            {
                this.isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (this.isPlaying)
            {
                this.isPlaying = false;
                Console.WriteLine("Stopped at {0}", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
        }
    }
}

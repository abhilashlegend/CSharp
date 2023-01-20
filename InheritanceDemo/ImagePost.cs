using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class ImagePost : Post
    {
        public string ImageUrl { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageUrl, bool isPublic)
        {
            this.ID = getNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} by {3}", this.ID, this.Title, this.ImageUrl, this.SendByUsername);
        }
    }
}

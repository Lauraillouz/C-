using System;
namespace InheritanceDemo
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // coming directly from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // member property of ImagePost
            ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - link: {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}

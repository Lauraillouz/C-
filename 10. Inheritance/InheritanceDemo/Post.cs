using System;
namespace InheritanceDemo
{
    public class Post
    {
        private static int CurrentPostId;

        // properties
        // protected means that it can only be used in directly related classes
        protected  int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // default constructor
        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUsername = "Laura";
        }

        // instance constructor
        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++CurrentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }

    }
}

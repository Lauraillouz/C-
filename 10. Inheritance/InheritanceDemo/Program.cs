using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Post post1 = new Post("First post", "Fred Astair", true);
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("First image post", "Serge Gainsbourg", "https://image.jpg", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("First video post", "Robert Mitchum", "https://video.mv4", 210, true);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.PlayVideo();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.StopVideo();
            Console.ReadLine();

        }
    }
}

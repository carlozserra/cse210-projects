using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("The Church of Jesus Christ", "General Conference", 2000);
        Video v2 = new Video("Me", "How to Sleep Faster", 300);
        Video v3 = new Video("TikTok", "Funny Videos 2024", 500);
        Video v4 = new Video("Driver", "Driving - The Movie", 800);
        

        v1.AddComment(new Comment("Bryan","What a Amazing experience!"));
        v1.AddComment(new Comment("Suzan","I'm church girl!"));
        v1.AddComment(new Comment("Caroline","I love the propeth!"));
        v1.AddComment(new Comment("Chad"," Wonderful!"));

        v2.AddComment(new Comment("Bryan","Who watch these kind of videos?!"));
        v2.AddComment(new Comment("Suzan","It doesn't work"));
        v2.AddComment(new Comment("Caroline","Zzz"));
        v2.AddComment(new Comment("Chad"," Awesome!"));

        v3.AddComment(new Comment("Bryan","LoL"));
        v3.AddComment(new Comment("Suzan","how can I share it? "));
        v3.AddComment(new Comment("Caroline","Was that my mom?"));
        v3.AddComment(new Comment("Chad"," All right, perfect!"));

        v4.AddComment(new Comment("Bryan","I miss popcorn right now"));
        v4.AddComment(new Comment("Suzan"," I was waiting so long for this"));
        v4.AddComment(new Comment("Caroline","who is the actor? "));
        v4.AddComment(new Comment("Chad"," Okay? "));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

         foreach (var video in videos)
        {
            Console.WriteLine($"Video:");
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to make bread", "Maria", 300);
        v1.AddComment(new Comment("jhon", "i loved the recipe"));
        v1.AddComment(new Comment("Anne", "very easy"));
        v1.AddComment(new Comment("Carl", "it was delicios"));

        Video v2 = new Video("Math Class", "Teacher Ross", 80);
        v2.AddComment(new Comment("luke", "Excellent explanation"));
        v2.AddComment(new Comment("Sarah", "Thanks for help me!"));
        v2.AddComment(new Comment("Joseph", "Great tips"));

        Video v3 = new Video("Trip to Japan", "Michael", 15);
        v3.AddComment(new Comment("Joel", "So beatiful places"));
        v3.AddComment(new Comment("Sophie", "I want visit too!"));
        v3.AddComment(new Comment("Ted", "Great tips."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }

    }
}
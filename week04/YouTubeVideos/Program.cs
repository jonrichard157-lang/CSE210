using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C# Classes", "Code Academy", 600);
        video1.AddComment(new Comment("João", "This video helped me understand classes."));
        video1.AddComment(new Comment("Maria", "Great explanation!"));
        video1.AddComment(new Comment("Carlos", "Very useful content."));

        Video video2 = new Video("HTML and CSS Basics", "Web Dev Pro", 750);
        video2.AddComment(new Comment("Ana", "I liked the website examples."));
        video2.AddComment(new Comment("Pedro", "Very clear and easy to follow."));
        video2.AddComment(new Comment("Lucas", "Please make more videos about CSS."));

        Video video3 = new Video("Git and GitHub for Beginners", "Tech Teacher", 900);
        video3.AddComment(new Comment("Fernanda", "Now I understand commits better."));
        video3.AddComment(new Comment("Bruno", "This helped me upload my project."));
        video3.AddComment(new Comment("Rafael", "Great tutorial for beginners."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
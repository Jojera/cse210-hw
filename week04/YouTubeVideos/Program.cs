using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         // Creating Video 1
        Video video1 = new Video("C# Basics Tutorial", "John Doe", 600);
        video1.AddComment(new Comment("Jonathan", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Samuel", "I finally understand classes in C#!"));

        // Creating Video 2
        Video video2 = new Video("How to Cook Pasta", "Chef Emma", 900);
        video2.AddComment(new Comment("Ojera", "Looks delicious!"));
        video2.AddComment(new Comment("Brandon", "I'll try this tonight!"));
        video2.AddComment(new Comment("Tyson", "Can you make a pizza tutorial next?"));

        // Creating Video 3
        Video video3 = new Video("Guitar Chords for Beginners", "Mike Music", 1200);
        video3.AddComment(new Comment("Grace", "Really useful, thanks!"));
        video3.AddComment(new Comment("Innocent", "What guitar are you using?"));
        video3.AddComment(new Comment("Angel", "Best tutorial I’ve seen!"));

        // Creating a List of Videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying all videos and their comments
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}


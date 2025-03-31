using System;
using System.Collections.Generic;

public class Video
{
    
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // Constructor (Initialization)
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); // Initialize empty list
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Public method to get the number of comments demonstrates abstraction.
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Public method to display video details (demonstrates abstraction)
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine("-------------------------\n");
    }
}
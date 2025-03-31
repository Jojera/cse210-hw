using System;

public class Comment
{
    // Private fields (Encapsulation)
    private string _commenterName;
    private string _commentText;

    // Constructor (Initialization)
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Public method to display the comment
    public void DisplayComment()
    {
        Console.WriteLine($"- {_commenterName}: {_commentText}");
    }
}
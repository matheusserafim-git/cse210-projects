using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;

    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComment()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration:{_duration}");
        Console.WriteLine($"Comments: {GetNumberOfComment()}");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"-{comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }   
}

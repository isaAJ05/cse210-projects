using System;

public class Video
{
    private string _title;
    private string _author;
    private int _len;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int len)
    {
        _title = title;
        _author = author;
        _len = len;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        int count = 0;
        foreach (Comment c in _comments)
        {
            count += 1;
        }

        return count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title},");
    }

}
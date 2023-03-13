using System;

class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine($"{_title} | {_author} | {_length} minutes");
        foreach(Comment comment in _comments)
        {
            comment.Display();
        }
    }
}
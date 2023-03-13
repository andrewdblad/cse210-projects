using System;

class Comment
{
    private string _text = "";
    private string _name = "";

    public Comment(string text, string name)
    {
        _text = text;
        _name = name;
    }
    public void Display()
    {
        Console.WriteLine($"{_name} - {_text}");
    }
}
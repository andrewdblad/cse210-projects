using System;
using System.Collections.Generic;

class Word
{
    private string _text = "";
    private bool _hidden = false;

    
    public Word(string text)
    {
     _text = text;
    }
    public void Display()
    {
        if (_hidden)
        {
            foreach (char character in _text)
            {
                Console.Write("_");
            }
        }
        else {
            Console.Write(_text);
        }
    }

}

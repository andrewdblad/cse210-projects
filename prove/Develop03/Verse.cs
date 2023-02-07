using System;
using System.Collections.Generic;

    class Verse
    {
        private List<Word> _words;
        public Verse(string verse)
        {
            _words = new List<Word>();

            char[] delimiterChars = { ' ', ':', '\t' };
            string[] words = verse.Split(delimiterChars);
            foreach (string wordString in words)
            {
            Word word = new Word(wordString);
            _words.Add(word);
            }
        }
        public void Display()
        {
            foreach (Word word in _words)
            {
            word.Display();
            Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
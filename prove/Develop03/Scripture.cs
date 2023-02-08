using System;
using System.Collections.Generic;

    class Scripture
    {
        private List<Verse> _verses = new List<Verse>();

        public Scripture(List<string> verses)
        {
            foreach (string verseString in verses)
            {
                Verse verse = new Verse(verseString);
                _verses.Add(verse); 
            }
        }
        public void Display()
        {
            foreach (Verse verse in _verses)
            {
                verse.Display();
            }
        }
        public bool HideWords(int count)
        {
            return false;
        }
        public bool IsAllHidden()
        {
            // ask all the verses if they are hidden
            return false;
        }
    }
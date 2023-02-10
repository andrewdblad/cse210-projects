using System;
using System.Collections.Generic;

    class Scripture
    {
        Random random = new Random();
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
        public List<string> WordsList(List<string> verses)
        {
            List<string> words = new List<string>();
            var combinedString = String.Join(" ", verses.ToList());
            foreach(string word in combinedString.Split(" "))
            {
                words.Add(word);
            }
            return words;
        }

        public void RandomWords(List<string> words)
        {
            int number = 0;

            while (number != 3)
            {
                
            int count = words.Count();
            int indexVal = random.Next(count);
            string word = words[indexVal];
            for(int i=0;i<count;i++)
                {
                    if(words[i].Contains(word))
                    {
                        int charCount = word.Count();
                        string dashes = new String('_', charCount);
                        words.RemoveAt(indexVal);
                        words.Insert(indexVal, dashes);

                    }
                }

            number = number + 1;
            }
            
        }

        public void HideWords(int count)
        {
        }
        public bool IsAllHidden()
        {
            // ask all the verses if they are hidden
            return false;
        }
    }
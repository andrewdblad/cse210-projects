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

        public List<string> RandomWords(List<string> words)
        {
            int number = 0;

            while (number != 1)
            {
                int count = words.Count();
                for(int i=0;i<count;i++)
                {             
                    int indexVal = random.Next(count);
                    string word = words[indexVal];
                    if(words[i].Contains(word))
                    {
                        int charCount = word.Count();
                        word = new String('_', charCount);
                        words.RemoveAt(indexVal);
                        words.Insert(indexVal, word);
                        
                    }
                
                }
            number = number + 1;
            }
            return words;
        }

        public List<string> PassThrough(List<string> wordsWithDashes)
        {

            return wordsWithDashes;
        }
        public bool IsAllHidden()
        {
            // ask all the verses if they are hidden
            return false;
        }
    }
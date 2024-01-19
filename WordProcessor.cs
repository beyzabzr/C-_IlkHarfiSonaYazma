using System;
namespace KelimeninIlkHarfiniSonunaYazma
{
    class WordProcessor
    {
        public string AddEndOfWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char firstLetter = words[i][0];
                    words[i] = words[i].Substring(1) + firstLetter;
                }
            }

            return string.Join(" ", words);
        }
    }
}
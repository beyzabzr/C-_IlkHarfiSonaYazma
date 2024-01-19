using System;
namespace KelimeninIlkHarfiniSonunaYazma
{
    class InputHandler
    {
        public string[] GetWords(string input)
        {
            return input.Split(' ');
        }
    }
}
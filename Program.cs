using System;
namespace KelimeninIlkHarfiniSonunaYazma
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Konsoldan girilen string ifadenin ilk indexini sonun yazma***");
            Console.WriteLine("Lutfen string bir ifade giriniz: ");

            string userInput = Console.ReadLine();

            InputHandler inputHandler = new InputHandler();
            string[] words = inputHandler.GetWords(userInput);

            WordProcessor wordProcessor = new WordProcessor();
            string modifiedString = wordProcessor.AddEndOfWords(words);

            Console.WriteLine(modifiedString);
        }
    }
}
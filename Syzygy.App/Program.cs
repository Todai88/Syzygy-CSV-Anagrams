using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syzygy.BL;

namespace Syzygy.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read file
            CSVReader reader = new CSVReader("../../../CsvTest.csv");
            var words = reader.Read();

            // Create a list of dictionaries (length:list<string>)
            // Makes the string comparisson a lot quicker as we don't have to
            // iterate over the entire list multiple times.
            var dictionaryList = new List<WordDictionary>();
            CreateDictionaries(words, ref dictionaryList);

            var wordHandler = new WordHandler();
            List<string> anagrams = wordHandler.FindAnagrams(dictionaryList);

            ShowAndWrite(anagrams);

        }






        /// <summary>
        /// Prints and writes to file.
        /// </summary>
        /// <param name="Anagrams"></param>
        private static void ShowAndWrite(List<string> Anagrams)
        {
            Console.WriteLine("Amount of anagrams: " + Anagrams.Count + "\n");
            foreach (var word in Anagrams)
            {
                Console.WriteLine($"{word.Length}:{word}");
            }
            var fw = new FileWriter(Anagrams);
        }

        /// <summary>
        /// Uses the CSV-parsed words to create a list of dictionaries
        /// where each dictionary holds an integer (length) and a list of words.
        /// </summary>
        /// <param name="words"></param>            The words from our CSV-file
        /// <param name="dictionaryList"></param>   A reference to the memory-address of the list of dictionaries.
        private static void CreateDictionaries(IEnumerable<string> words, ref List<WordDictionary> dictionaryList)
        {
            var dictionary = new WordDictionary(1);
            foreach (var word in words.OrderBy(w => w.Length))
            {
                if (word.Length != dictionary.Length)
                {
                    dictionaryList.Add(dictionary);
                    dictionary = new WordDictionary(word.Length);
                }
                dictionary.AddWord(word);
            }
        } 
    }
}

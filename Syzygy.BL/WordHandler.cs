using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syzygy.BL
{
    public class WordHandler
    {
        /// <summary>
        /// Simply iterates over the list of words looking for
        /// any occurrences of the scrambled word-parameter.
        /// Since each dictionary will at least hold ONE 
        /// word it will match with (itself) we need a count
        /// variable to ensure that we only return matches 
        /// on other words.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public bool CompareWords (string word, List<string> words)
        {
            int count = 0;
            foreach(var dictionaryWord in words)
            {
                var sortedDictionaryWord = String.Concat(dictionaryWord.ToLower()
                                                         .OrderBy(c => c));
                var sortedWord = String.Concat(word.ToLower()
                                                .OrderBy(c => c));
                if (sortedDictionaryWord == sortedWord)
                {
                    if(count > 0)
                    {
                        return true;
                    }
                    count++;
                }
            }
            return false;
        }

        public List<string> FindAnagrams(List<WordDictionary> dictionaryList)
        {
            var Anagrams = new List<string>(); 
            foreach (var dictionary in dictionaryList)
            {
                foreach (var word in dictionary.Words)
                {
                    if (CompareWords(word, dictionary.Words))
                    {
                        Anagrams.Add(word);
                    }
                }
            }

            return Anagrams;
        }

    }
}

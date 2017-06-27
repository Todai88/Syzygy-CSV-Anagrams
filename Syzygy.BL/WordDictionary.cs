using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syzygy.BL
{
    public class WordDictionary
    {
        public int Length { get; set; }
        public List<string> Words { get; set; }

        public WordDictionary(int length)
        {
            Length = length;
            Words = new List<string>();
        }

        public void AddWord(string word)
        {
            Words.Add(word);
        }
    }
}

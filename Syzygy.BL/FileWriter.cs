using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syzygy.BL
{
    public class FileWriter
    {
        public FileWriter(List<string> listToWrite)
        {
            using (StreamWriter writeText = new StreamWriter("Anagrams.txt"))
            {
                writeText.WriteLine($"Anagram Count:{listToWrite.Count}");
                listToWrite.ForEach(w => 
                                    writeText.WriteLine($"{w.Length}:{w}"));
            }
        }
    }
}

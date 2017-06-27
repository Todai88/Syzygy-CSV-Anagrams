using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syzygy.BL
{
    public class CSVReader
    {
        public string Path { get; set; }
        public CSVReader(string path)
        {
            Path = @""+path;
        }

        public IEnumerable<string> Read()
        {
            return File.ReadAllLines(Path)
                            .SelectMany(w => w.Split(',')).Where(w => !String.IsNullOrEmpty(w));  
        }
    }
}

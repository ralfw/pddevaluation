using System.IO;
using System.Linq;

namespace wordcount
{
    internal class StopwordsProvider
    {
        private readonly string _filename;
        public StopwordsProvider() : this("stopwords.txt") {}
        internal StopwordsProvider(string filename) { _filename = filename; }
        
        public string[] Load() {
            if (!File.Exists(_filename)) return new string[0];
            
            var lines = File.ReadAllLines(_filename);
            return lines.Select(l => l.Trim())
                        .Where(l => !string.IsNullOrWhiteSpace(l))
                        .ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace wordcount
{
    internal class Wordcounting
    {
        public static int Count_words(string[] words) {
            return words.Length;
        }

        public static string[] Filter(string[] words, string[] stopwords) {
            var stopwordshash = new HashSet<string>(stopwords);
            return words.Where(word => !stopwordshash.Contains(word)).ToArray();
        }
    }
}
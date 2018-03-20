using System;

namespace wordcount
{
    internal class Wordcounting
    {
        public int Count_words(string text) {
            var words = text.Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
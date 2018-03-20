using System;

namespace wordcount
{
    internal class RequestHandler
    {
        public int Count_words(string text) {
            var words = text.Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
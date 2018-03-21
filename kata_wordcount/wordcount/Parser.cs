using System;

namespace wordcount
{
    internal class Parser
    {
        public static string[] Split(string text)
        {
            return text.Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
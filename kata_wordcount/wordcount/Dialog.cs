using System;

namespace wordcount
{
    internal class Dialog
    {
        public string Ask_for_text() {
            Console.Write("Text: ");
            return Console.ReadLine();
        }

        public void Display_result(int wortanzahl) {
            Console.WriteLine($"Anzahl Worte im Text: {wortanzahl}");
        }
    }
}
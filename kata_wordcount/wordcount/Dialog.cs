using System;

namespace wordcount
{
    internal class Dialog
    {
        public string Text_erfragen() {
            Console.Write("Text: ");
            return Console.ReadLine();
        }

        public void Ergebnis_anzeigen(int wortanzahl) {
            Console.WriteLine($"Anzahl Worte im Text: {wordanzahl}");
        }
    }
}
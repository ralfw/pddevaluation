using System;

namespace wordcount
{
    internal class Dialog
    {
        public string Ask_for_text() {
            Console.Write("Text: ");
            return Console.ReadLine();
        }

        public void Repeatedly_ask_for_text(Action<string> onText)
        {
            while (true) {
                var text = Ask_for_text();
                if (text == "") break;
                onText(text);
            }
        }

        public void Display_result(int wortanzahl) {
            Console.WriteLine($"Anzahl Worte im Text: {wortanzahl}");
        }
    }
}
using System;
using System.IO;

namespace more
{
    internal class Zeilenspender {
        public void Laden(string dateiname, Ampel ampel, Action<string> beiZeile) {
            var s = new StreamReader(dateiname);
            while (!s.EndOfStream && ampel.Farbe == Ampel.Ampelfarben.Grün) {
                var zeile = s.ReadLine();
                beiZeile(zeile);
            }
        }
    }
}
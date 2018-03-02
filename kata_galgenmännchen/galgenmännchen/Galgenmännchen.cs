using System;

namespace galgenmännchen
{
    // @todo #1: Worte mit mehreren Buchstaben
    public class Galgenmännchen {
        private readonly string _gesuchtesWort;

        public Galgenmännchen(string gesuchtesWort) {
            _gesuchtesWort = gesuchtesWort;
        }

        // @todo #1: Gross/Kleinschreibung nicht unterscheiden
        public string RateBuchstabe(char buchstabe)
        {
            if (_gesuchtesWort[0] == buchstabe)
                return _gesuchtesWort;
            return "-";
        }
    }
}
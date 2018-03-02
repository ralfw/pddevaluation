using System;

namespace galgenmännchen
{
    // @todo #1: Worte mit mehreren Buchstaben
    public class Galgenmännchen {
        private readonly string _gesuchtesWort;

        public Galgenmännchen(string gesuchtesWort) {
            _gesuchtesWort = gesuchtesWort;
        }

        public string RateBuchstabe(char buchstabe)
        {
            if (char.ToLower(_gesuchtesWort[0]) == char.ToLower(buchstabe))
                return _gesuchtesWort;
            return "-";
        }
    }
}
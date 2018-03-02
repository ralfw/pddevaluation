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

            return Check_char(_gesuchtesWort[0], buchstabe).ToString();
        }

        private char Check_char(char wortbuchtabe, char gesuchterBuchstabe) {
            if (char.ToLower(wortbuchtabe) == char.ToLower(gesuchterBuchstabe))
                return wortbuchtabe;
            return '-';
        }
    }
}
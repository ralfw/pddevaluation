using System;

namespace galgenmännchen
{
    public class Galgenmännchen {
        private readonly string _gesuchtesWort;
        private readonly char[] _erratenesWort;

        public Galgenmännchen(string gesuchtesWort) {
            _gesuchtesWort = gesuchtesWort;
            _erratenesWort = "".PadLeft(gesuchtesWort.Length, '-').ToCharArray();
        }

        // @todo #1 Besser strukturieren nach IOSP
        public string RateBuchstabe(char buchstabe)
        {
            for(var i=0; i<_erratenesWort.Length; i++)
            {
                if (_erratenesWort[i] == '-')
                    _erratenesWort[i] = Check_char(_gesuchtesWort[i], buchstabe);
            }
            return new string(_erratenesWort);
        }

        private char Check_char(char wortbuchtabe, char gesuchterBuchstabe) {
            if (char.ToLower(wortbuchtabe) == char.ToLower(gesuchterBuchstabe))
                return wortbuchtabe;
            return '-';
        }
    }
}
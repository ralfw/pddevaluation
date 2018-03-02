using System;
using System.Linq;

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
        public string RateBuchstabe(char buchstabe) {
            Find_missing_char_positions(
                i => _erratenesWort[i] = Check_char(_gesuchtesWort[i], buchstabe));
            return new string(_erratenesWort);
        }


        private void Find_missing_char_positions(Action<int> onMissing) {
            for(var i=0; i<_erratenesWort.Length; i++)
                if (_erratenesWort[i] == '-')
                    onMissing(i);
        }
        
        
        private char Check_char(char wortbuchtabe, char gesuchterBuchstabe)
            => char.ToLower(wortbuchtabe) == char.ToLower(gesuchterBuchstabe) ? wortbuchtabe : '-';
    }
}
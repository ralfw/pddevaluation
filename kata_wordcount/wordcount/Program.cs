namespace wordcount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dlg = new Dialog();
            var rh = new RequestHandler();

            var text = dlg.Text_erfragen();
            var wortanzahl = rh.Count_words(text);
            dlg.Ergebnis_anzeigen(wortanzahl);
        }
    }
}
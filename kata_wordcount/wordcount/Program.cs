namespace wordcount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dlg = new Dialog();
            var swp = new StopwordsProvider();
            var rh = new RequestHandler(swp);

            dlg.Repeatedly_ask_for_text(text => {
                var wordcount = rh.Count_words(text);
                dlg.Display_result(wordcount);
            });
        }
    }
}
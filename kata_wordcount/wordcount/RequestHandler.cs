namespace wordcount
{
    internal class RequestHandler
    {
        private readonly StopwordsProvider _stopwordsprovider;
        public RequestHandler(StopwordsProvider stopwordsprovider) {
            _stopwordsprovider = stopwordsprovider;
        }
        
        public int Count_words(string text) {
            var words = Parser.Split(text);
            words = Filter(words);
            return Wordcounting.Count_words(words);
        }

        string[] Filter(string[] words) {
            var stopwords = _stopwordsprovider.Load();
            return Wordcounting.Filter(words, stopwords);
        }
    }
}
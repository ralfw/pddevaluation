namespace more
{
    internal class CLI
    {
        private readonly string[] _args;
        public CLI(string[] args) {
            _args = args;
        }

        public string Dateiname => _args[0];
    }
}
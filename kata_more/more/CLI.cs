namespace more
{
    internal class CLI
    {
        private readonly string[] _args;
        public CLI(string[] args) {
            _args = args;
        }

        public string Filename => _args[0];
    }
}
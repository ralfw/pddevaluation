namespace more
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var prg = new Program();
            prg.Run(args);
        }


        public void Run(string[] args)
        {
            var cli = new CLI(args);
        }
    }
}
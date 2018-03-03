namespace todo
{
    // @todo #11 CLI/Console UI entwerfen
    internal class MainController
    {
        public static void Main(string[] args)
        {
            var app = new MainController(args);
            app.Run();
        }
        
        
        public MainController(string[] args) {}
        
        public void Run() {}
    }
}
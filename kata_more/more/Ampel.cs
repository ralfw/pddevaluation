namespace more
{
    internal class Ampel
    {
        public enum Ampelfarben { Grün, Gelb, Rot }

        public Ampel() { Farbe = Ampelfarben.Grün; }
        
        public Ampelfarben Farbe { get; set; }
    }
}
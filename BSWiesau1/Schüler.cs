namespace BSWiesau1
{
    public class Schüler : Mensch
    {
        private string _schulklasse;

        public string Schulklasse
        {
            get => _schulklasse;
            set
            {
                if (value.Length == 6)
                {
                    _schulklasse = value;
                }
                else
                {
                    throw new ArgumentException("Schulklasse muss genau 6 Zeichen lang sein.");
                }
            }
        }

        public Schüler(string vorname, string nachname, DateTime geburtsdatum, string schulklasse)
            : base(vorname, nachname, geburtsdatum)
        {
            Schulklasse = schulklasse;
        }

        public override void Sprechen()
        {
            Console.WriteLine("Guten Morgen, Herr Lehrer");
        }

        public override void Arbeiten()
        {
            Console.WriteLine("Schule ist schlimmer als Arbeiten.");
        }
    }
}
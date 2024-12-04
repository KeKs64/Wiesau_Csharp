namespace BSWiesau1;

public class Lehrer : Mensch
{
    public Lehrer(string vorname, string nachname, DateTime geburtsdatum) : base(vorname, nachname, geburtsdatum)
    {
    }

    public override void Sprechen()
    {
        Console.WriteLine("Guten Morgen, Klasse!");
    }
    public override void Arbeiten()
    {
        Console.WriteLine("In der Schule arbeiten ist schlimm.");
    }
}


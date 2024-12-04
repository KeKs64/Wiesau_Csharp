namespace BSWiesau1;

public class Personal : Mensch
{
    private string _Abteilung = default;

    public string Abteilung
    {
        get => _Abteilung;
        set => _Abteilung = value;
    }
    
    public Personal(string vorname, string nachname, DateTime geburtsdatum, string abteilung) : base(vorname, nachname, geburtsdatum)
    {
        _Abteilung = abteilung;
    }

    public override void Sprechen()
    {
        Console.WriteLine("Im Flur wird nicht gerannt!");
    }
    public override void Arbeiten()
    {
        Console.WriteLine("Ich arbeite in der Schule.");
    }
}
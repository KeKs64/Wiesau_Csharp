namespace BSWiesau1;

public class Mensch
{
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    private DateTime _geburtsdatum;
    public DateTime Geburtsdatum
    {
        get => _geburtsdatum;
        set 
        {
            if (value > DateTime.Today)
            {
                throw new ArgumentOutOfRangeException("Geburtsdatum", "Das Geburtsdatum darf nicht in der Zukunft liegen.");
            }
            _geburtsdatum = value; 
        }
    }

    public Mensch(string vorname, string nachname, DateTime geburtsdatum)
    {
        Vorname = vorname;
        Nachname = nachname;
        Geburtsdatum = geburtsdatum;
    }

    public virtual void Sprechen()
    {
        Console.WriteLine("Ich bin ein Mensch und kann sprechen");
    }

    public virtual void Arbeiten()
    {
        Console.WriteLine("Ich bin ein Mensch und muss arbeiten");
    }
}



namespace Buchhaltungssoftware;

public class Transaktion
{
    public DateTime Datum { get; set; }
    public decimal Betrag { get; set; }
    public string Beschreibung { get; set; }

    public Transaktion(DateTime datum, decimal betrag, string beschreibung)
    {
        Datum = datum;
        Betrag = betrag;
        Beschreibung = beschreibung;
    }
}
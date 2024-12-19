namespace Buchhaltungssoftware;

public class Konto
{
    public string Kontonummer { get; set; }
    public decimal Kontostand { get; set; }
    public List<Transaktion> Transaktionsliste { get; set; }
    public Konto(string kontonummer)
    {
        Kontonummer = kontonummer;
        Kontostand = 0;
        Transaktionsliste = new List<Transaktion>();
    }

    public virtual void Einzahlen(decimal betrag, string beschreibung)
    {
        Kontostand += betrag;
        Transaktion Einzahlung = new Transaktion(DateTime.Now, betrag, beschreibung);
        Transaktionsliste.Add(Einzahlung);
    }

    public virtual void Abheben(decimal betrag, string beschreibung)
    {
        Kontostand -= betrag;
        Transaktion Abhebung = new Transaktion(DateTime.Now, betrag, beschreibung);
        Transaktionsliste.Add(Abhebung);
        Console.WriteLine("Abhebung erfolgreich.");
    }

    public void TransaktionenAnzeigen()
    {
        foreach (var transaktion in Transaktionsliste)
        {
            Console.WriteLine($"Datum: {transaktion.Datum}, Betrag: {transaktion.Betrag}, Beschreibung: {transaktion.Beschreibung}");
        }
    }
    
}
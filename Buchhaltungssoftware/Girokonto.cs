namespace Buchhaltungssoftware;

public class Girokonto : Konto
{
    public decimal Überziehungslimit { get; set; }

    public Girokonto(string kontonummer, decimal überziehungslimit) : base(kontonummer)
    {
        Überziehungslimit = überziehungslimit;
    }

    public override void Einzahlen(decimal betrag, string beschreibung)
    {
        base.Einzahlen(betrag, beschreibung);
    }

    public override void Abheben(decimal betrag, string beschreibung)
    {
        if (Kontostand - betrag >= -Überziehungslimit)
        {
            Kontostand -= betrag;
            Transaktion Abhebung = new Transaktion(DateTime.Now, betrag, beschreibung);
            Transaktionsliste.Add(Abhebung);
        }
        else
        {
            Console.WriteLine("Abhebung nicht möglich. Überziehungslimit erreicht.");
        }
    }
}
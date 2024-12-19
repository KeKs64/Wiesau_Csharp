namespace Buchhaltungssoftware;

public class Sparkonto : Konto
{
    public decimal Zinssatz { get; set; }

    public Sparkonto(string kontonummer, decimal zinssatz) : base(kontonummer)
    {
        Zinssatz = zinssatz;
    }

    public void ZinsenHinzufügen()
    {
        decimal zinsen = Kontostand * Zinssatz;
        Kontostand += zinsen;
        
        Transaktion transaktion = new Transaktion(DateTime.Now, zinsen, "Zinsgutschrift");
        Transaktionsliste.Add(transaktion);
    }
}
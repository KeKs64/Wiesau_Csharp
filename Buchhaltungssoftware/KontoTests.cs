using System;
using Buchhaltungssoftware;

public class KontoTests
{
    public static void GirokontoTest()
    {
        Console.WriteLine("\nGirokonto Test:");
        Girokonto girokonto = new Girokonto("DE1234567890", 1000);
        girokonto.Einzahlen(1500, "Gehalt");
        girokonto.Abheben(500, "Miete");
        girokonto.Abheben(200, "Einkauf");
        girokonto.TransaktionenAnzeigen();

        // Teste Überziehungslimit
        Console.WriteLine("\nTeste Überziehungslimit:");
        girokonto.Abheben(10000, "Überziehungstest");
        girokonto.TransaktionenAnzeigen();
    }

    public static void SparkontoTest()
    {
        Console.WriteLine("\nSparkonto Test:");
        Sparkonto sparkonto = new Sparkonto("DE9876543210", 0.02m);
        sparkonto.Einzahlen(5000, "Einzahlung");
        sparkonto.Abheben(1000, "Abhebung");
        sparkonto.ZinsenHinzufügen();
        sparkonto.TransaktionenAnzeigen();
    }

    // TODO: Weitere Testmethoden für Kontoauszug, etc.
}
namespace Übungsaufgabe_Polymorphie;

internal static class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            _name = "Joe Unemployed",
            _einkommen = 6400
        };

        Arbeiter arbeiter = new Arbeiter
        {
            _name = "Susi Hard Working",
            _einkommen = 33600
        };

        Banker banker = new Banker
        {
            _name = "Fred Moneymaker",
            _einkommen = 4000000
        };

        Königin königin = new Königin
        {
            _name = "Elizabeth",
            _einkommen = 1000000
        };

        Person[] personenliste = new[] { person, arbeiter, banker, königin }; 
        
        double gesamteSteuer = Finanzamt.berechneGesamteSteuerEinnahmen(personenliste);
        
        Console.WriteLine($"Gesamte Steuereinnahmen: {gesamteSteuer}");
    }
}